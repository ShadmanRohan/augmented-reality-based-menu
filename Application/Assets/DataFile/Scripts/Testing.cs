using System;
using System.Collections.Generic;
public class Testing : ShowOrderList
{
    public bool checkTableNO(int totalTable, string givenNo)
    {
        int tableno = 0;
        try
        {
            tableno = Convert.ToInt32(givenNo);
        }
        catch(Exception e)
        {
            SSTools.ShowMessage("Not a Valid Input", SSTools.Position.bottom, SSTools.Time.twoSecond);
        }
        if (tableno <= totalTable && tableno > 0)
        {
            return true;
        }

        SSTools.ShowMessage("Input Valid Table No", SSTools.Position.bottom, SSTools.Time.twoSecond);
        return false;
    }
    public bool checkQuantity(string quantity)
    {
        int quan = 0;
        try
        {
            quan = Convert.ToInt32(quantity);
        } catch (Exception e)
        {
            SSTools.ShowMessage("Input Valid Quantity", SSTools.Position.bottom, SSTools.Time.twoSecond);
            return false;
        }
        if (quan > 0)
        {
            return true;
        }
        SSTools.ShowMessage("Input Valid Quantity", SSTools.Position.bottom, SSTools.Time.twoSecond);
        return false;
    }
    public void checkOrderList_and_Show(List<OrderItems> orderItems)
    {
        if(!checkOrderListEmpty(orderItems))
        {
            showtotalbill("0");
            return;
        }
        show(orderItems);
        
    }
    public bool checkOrderListEmpty(List<OrderItems> orderItems)
    {
        if (orderItems.Count == 0)
        {
            SSTools.ShowMessage("Place Some Order First", SSTools.Position.bottom, SSTools.Time.twoSecond);
            return false;
        }
        return true;
    }
}
