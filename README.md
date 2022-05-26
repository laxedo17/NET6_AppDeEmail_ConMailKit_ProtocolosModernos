# NET6 App de email con MailKit usando Protocolos modernos
Aplicacion de email usando MailKit. 
Importante!: Microsoft non recomenda usar SmtpClient porque non admite protocolos modernos, e agora recomenda utilizar MailKit. 
Mais info en documentación de Microsoft (castellano) https://docs.microsoft.com/es-es/dotnet/api/system.net.mail.smtpclient?view=net-6.0 . 

More info on Microsoft's documentation (english) https://docs.microsoft.com/en-us/dotnet/api/system.net.mail.smtpclient?view=net-6.0 . 
Paquete nuget Mailkit: https://www.nuget.org/packages/MailKit/ 

Explicacion de Microsoft de porque non debería usarse a clase SmtpClient. Microsoft's explanation on why SmtpClient shouldn't be used.

https://github.com/dotnet/platform-compat/blob/master/docs/DE0005.md 

Usamos conta de email de Ethereal. Ethereal e un servicio fake de email SMTP co cal podes testear tua app de email.
Crean un email de mentira para ti tras clickar en Create Ethereal account

https://ethereal.email/  

We use an email account from Ethereal. Ethereal is a fake SMTP email service with which you can test your email app.
They create a fake email account for you after clicking on Create Ethereal account

A app funcionando // The app working

![image](https://user-images.githubusercontent.com/44708275/170601336-33f07579-2ed4-4ccf-9a17-dd75ccc694b1.png)

![image](https://user-images.githubusercontent.com/44708275/170601421-3cd31542-db81-476d-9a06-6dc19ef3d506.png)

![image](https://user-images.githubusercontent.com/44708275/170601490-ac2748ef-12be-4261-89a8-62d724cd7386.png)
