USE [TCG_Inventory3]
GO
/****** Object:  StoredProcedure [dbo].[AddToCart]    Script Date: 2023-08-11 9:24:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Proc [dbo].[AddToCart]
@UID varchar(64), /*Store id*/
@CID int,
@Set_Code varchar(50),
@Rarity varchar(20),
@Quantity int, 
@price money 
as
Begin
    /*Check if card is in the shopping cart*/
    if not exists (select  user_id, card_id, set_code, rarity from dbo.ShoppingCart where user_id = @UID and card_id = @CID and set_code = @Set_Code and rarity = @Rarity) 
        Begin
            Insert into dbo.ShoppingCart 
                (user_id, card_id, set_code, rarity, quantity, price) 
            values 
                (@UID, @CID, @Set_Code, @Rarity, @Quantity, @price * @Quantity)
        End

    /*Update quantity if in shopping cart*/
    else
        Begin
            Update dbo.ShoppingCart
            SET quantity = @Quantity
        End
End