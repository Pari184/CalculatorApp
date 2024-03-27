<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="CalculatorApplication.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous" />

    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
    <title>Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid mt-100">
            <div class="form-group">
                <label class="col-3 col-form-label" for="number1">Number 1:</label>
                <asp:TextBox runat="server" ID="txtNum1"></asp:TextBox>
            </div>
            <div class="form-group">
                <label class="col-3 col-form-label" for="number2">Number 2:</label>
                <asp:TextBox runat="server" ID="txtNum2"></asp:TextBox>
            </div>
            <div class="form-group">
                <label class="col-3 col-form-label" for="result">Result:</label>
                <asp:TextBox runat="server" ID="txtResult" ></asp:TextBox>
            </div>
            <div class="col-md-9">
                <asp:Button runat="server" Text="+" class="btn btn-info" type="submit" id="btnAdd" name="calculate" value="add" OnClick="btnAdd_Click" />&nbsp;&nbsp;
                <asp:Button runat="server" Text="-" class="btn btn-info" type="submit" id="btnSub" name="calculate" value="sub" OnClick="btnSub_Click" />&nbsp;&nbsp;
                <asp:Button runat="server" Text="*" class="btn btn-info" type="submit" id="btnMul" name="calculate" value="mul" OnClick="btnMul_Click" />&nbsp;&nbsp;
                <asp:Button runat="server" Text="/" class="btn btn-info" type="submit" id="btnDiv" name="calculate" value="div" OnClick="btnDiv_Click" />
            </div>
        </div>
    </form>
</body>
</html>
