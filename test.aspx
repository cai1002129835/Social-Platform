<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>Form demo_����ͼ��</title>
<style type="text/css">
<!--
body {
    font-family: Arial, Helvetica, sans-serif;
    font-size:12px;
    color:#666666;
    background:#fff;
    text-align:center;

}

* {
    margin:0;
    padding:0;
}

a {
    color:#1E7ACE;
    text-decoration:none;    
}

a:hover {
    color:#000;
    text-decoration:underline;
}
h3 {
    font-size:14px;
    font-weight:bold;
}

pre,p {
    color:#1E7ACE;
    margin:4px;
}
input, select,textarea {
    padding:1px;
    margin:2px;
    font-size:11px;
}
.buttom{
    padding:1px 10px;
    font-size:12px;
    border:1px #1E7ACE solid;
    background:#D0F0FF;
}
#formwrapper {
    width:450px;
    margin:15px auto;
    padding:20px;
    text-align:left;
    border:1px #1E7ACE solid;
}

fieldset {
    padding:10px;
    margin-top:5px;
    border:1px solid #1E7ACE;
    background:#fff;
}

fieldset legend {
    color:#1E7ACE;
    font-weight:bold;
    padding:3px 20px 3px 20px;
    border:1px solid #1E7ACE;    
    background:#fff;
}

fieldset label {
    float:left;
    width:120px;
    text-align:right;
    padding:4px;
    margin:1px;
}

fieldset div {
    clear:left;
    margin-bottom:2px;
}

.enter{ text-align:center;}
.clear {
    clear:both;
}

-->
</style>
</head>

<body>
    <meta content="text/html; charset=gb2312" http-equiv="Content-Type" />
    <title>Form demo_����ͼ��</title>
    <style type="text/css">

<!--
body {
    font-family: Arial, Helvetica, sans-serif;
    font-size:12px;
    color:#666666;
    background:#fff;
    text-align:center;

}

* {
    margin:0;
    padding:0;
}

a {
    color:#1E7ACE;
    text-decoration:none;    
}

a:hover {
    color:#000;
    text-decoration:underline;
}
h3 {
    font-size:14px;
    font-weight:bold;
}

p {
    color:#1E7ACE;
    margin:4px;
}

pre {
    color:#1E7ACE;
    margin:4px;
}
textarea {
    padding:1px;
    margin:2px;
    font-size:11px;
}
select {
    padding:1px;
    margin:2px;
    font-size:11px;
}
input {
    padding:1px;
    margin:2px;
    font-size:11px;
}
.buttom{
    padding:1px 10px;
    font-size:12px;
    border:1px #1E7ACE solid;
    background:#D0F0FF;
}
#formwrapper {
    width:450px;
    margin:15px auto;
    padding:20px;
    text-align:left;
    border:1px #1E7ACE solid;
}

fieldset {
    padding:10px;
    margin-top:5px;
    border:1px solid #1E7ACE;
    background:#fff;
}

fieldset legend {
    color:#1E7ACE;
    font-weight:bold;
    padding:3px 20px 3px 20px;
    border:1px solid #1E7ACE;    
    background:#fff;
}

fieldset label {
    float:left;
    width:120px;
    text-align:right;
    padding:4px;
    margin:1px;
}

fieldset div {
    clear:left;
    margin-bottom:2px;
}

.enter{ text-align:center;}
.clear {
    clear:both;
}

-->
</style>
    <div id="formwrapper">
        <h3>��ע���û���¼</h3>
        <form id="apLogin" action="" method="post" name="apLogin">
            <fieldset>
                <legend>�û���¼</legend>
                <div>
                    <label for="Name0">
                    �û���</label>
                    <input id="Name" maxlength="30" name="Name1" size="18" type="text" /><br />
                </div>
                <div>
                    <label for="password0">
                    ����</label>
                    <input id="password" maxlength="15" name="password1" size="18" type="password" /><br />
                </div>
                <div class="cookiechk">
                    <label>
                    <input id="CookieYN" name="CookieYN" type="checkbox" value="1" /> <a href="#" title="ѡ���Ƿ��¼������Ϣ">��ס��</a></label>
                    <input class="buttom" name="login791" type="submit" value="��¼" />
                </div>
                <div class="forgotpass">
                    <a href="#">����������?</a></div>
            </fieldset>
        </form>
        <br />
        <h3>δע�ᴴ���ʻ�</h3>
        <form id="apForm" action="" method="post" name="apForm">
            <fieldset>
                <legend>�û�ע��</legend>
                <p>
                    <strong>���ĵ������䲻�ᱻ������ȥ,���Ǳ�����д.</strong> ����ע��֮ǰ���������Ķ���������.</p>
                <div>
                    <label for="Name0">
                    �û���</label>
                    <input id="Name0" maxlength="30" name="Name" size="20" type="text" value="" /> *(���30���ַ�)<br />
                </div>
                <div>
                    <label for="Email">
                    ��������</label>
                    <input id="Email" maxlength="150" name="Email" size="20" type="text" value="" /> *<br />
                </div>
                <div>
                    <label for="password0">
                    ����</label>
                    <input id="password0" maxlength="15" name="password" size="18" type="password" /> *(���15���ַ�)<br />
                </div>
                <div>
                    <label for="confirm_password">
                    �ظ�����</label>
                    <input id="confirm_password" maxlength="15" name="confirm_password" size="18" type="password" /> *<br />
                </div>
                <div>
                    <label for="AgreeToTerms">
                    ͬ���������</label>
                    <input id="AgreeToTerms" name="AgreeToTerms" type="checkbox" value="1" /> <a href="#" title="���Ƿ�ͬ���������">�ȿ������</a> *
                </div>
                <div class="enter">
                    <input class="buttom" name="create791" type="submit" value="�ύ" />
                    <input class="buttom" name="Submit" type="reset" value="����" />
                </div>
                <p>
                    <strong>* ���ύ����ע����Ϣʱ, ������Ϊ���Ѿ�ͬ�������ǵķ�������.<br />
                    * ��Щ���������δ����ͬ���ʱ������޸�.</strong></p>
            </fieldset>
        </form>
    </div>
    <p>
        ���Ҹ�����룬����ʣ�<a href="http://www.lanrentuku.com" target="_blank">����ͼ��</a></p>
</body>
</html>
