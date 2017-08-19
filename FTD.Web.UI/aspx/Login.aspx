<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OA.aspx.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>

    <head>
        
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
        <title><%=System.Configuration.ConfigurationManager.AppSettings["SYSTitle"]%></title>
     
	<link href="themes/css/content/layout.css" rel="stylesheet" />
	<link href="themes/css/content/deep.css" rel="stylesheet" />
   </head>

    <body  class="loginmain" >
        <form name="form1" action="login.aspx" autocomplete="off" method="post">
                <div class="login">
            <div class="containt">
                <div class="logintitle"><span class="bigtxt">用户登录</span><span class="smltxt">UserLogin</span></div>
                <div class="main">
                    <div class="iptline">
                        <i class="userico"></i>
                        <label class="iptplaceholder"></label>
                        <input type="text" id="TxtUserName" class="formipt" runat="server" />
                    </div>
                    <div id="usernameCheck" class="checkbox"></div>
                    <div class="iptline">
                        <i class="pwdico"></i>
                        <label class="iptplaceholder"></label>
                        <input type="password" id="TxtUserPwd" class="formipt" runat="server" />
                    </div>

                    <div id="verifyCheck" class="checkbox"></div>
                    <div class="butonline flt">
                        <input id="btnSubmit" type="submit" class="loginbtn" value="登录" />



                    </div>
                </div>
            </div>
        </div>
        <div class="footer"><a href="http://www.bogusoft.com.cn">技术支持：杭州博古科技有限公司</a></div>
        </form>
    </body>

   <script src="themes/js/public/jquery-1.11.0.min.js"></script>
<script>
    $(function () {
        //begin 2017-2-15 文本框点击仿placeholder
        $('.containt').on('click', '.iptplaceholder', function () {
            $(this).hide();
            $(this).next().focus();
        })

        $('.containt').on('focus', '.formipt', function () {
            if ($.trim($(this).val()) == "") {
                $(this).prev().hide();
            }
        })

        $('.containt').on('blur', '.formipt', function () {
            if ($.trim($(this).val()) == "") {
                $(this).prev().show();
            }
        })
        //end



        setPosition();
    })

    $(window).resize(function () { //浏览器放大缩小时
        setPosition();
    })

    function setPosition() { //定位内容和footer
        var wHeight = $(window).innerHeight();
        var paddingTop = (wHeight - 100 - 718) / 2;
        if (paddingTop > 0) {
            $('.login').css('paddingTop', paddingTop + 162 + 50);
            $('.login').css('paddingBottom', paddingTop + 162);
        }
    }
</script>

</html>

