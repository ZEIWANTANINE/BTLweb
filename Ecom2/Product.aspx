<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Ecom2.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .product-wrap{
            display:flex;
        }
        .product{
            border:dotted blue 1px;
            margin-left:5px;
            margin-right:5px;
        }
        .product img{
            width:300px;
        }
    </style>
</head>
<body>
        <div>
            <form method="post" action="Product.aspx">
            <label for="txtTenhang">Ten hang</label>
            <input type="text" id="txtTenhang" name="txtTenhang" value="<%=Request.Form["txtTenhang"] %>"/>
            <input type="submit"  value="tim" />
            </form>
        </div>
        <div class="product-wrap">
             <%var glstProduct = Application[Ecom2.Global.PRODUCT_LIST] as List<Ecom2.Product>; //lay danh sach tu list da tao,viet 2 product boi vi ten project laf Product
                 ///tim kiem
                 if (Request.Form["txtTenhang"] != null && !string.IsNullOrWhiteSpace(Request.Form["txtTenhang"]))
                 {
                     glstProduct = glstProduct.FindAll(p => p.Name.IndexOf(Request.Form["txtTenhang"], StringComparison.CurrentCultureIgnoreCase) >= 0);
                 }
                 foreach (var p in glstProduct)// duyet tung phan tu de hien hang hoa 
                 {
                %>
            <div class="product">
                <img src="<%=p.Imageurl%>"/>
             
                <div><%=p.Name %></div>
                <div><%=p.Price %></div>
            </div>
            <%} %>
        </div>
    
</body>
</html>
