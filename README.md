# OdnShop

#### 项目介绍
基于ASP.NET 4.0开发的开源微商城系统，我们的目标是构建一个核心完善而又轻量级的微商城平台。QQ群：94789779 （相关文档我们会更新到群文件，如果你没有码云账号，无法下载源码，可到群文件里下载）

#### 环境要求
支持ASP.NET 4.0的虚拟主机或服务器均可，数据库为开源的MySql数据库系统；

#### 安装流程
1，把安装包上传到主机空间；
2，在MYSQL里新建一个数据库qzbshop(也可以是其他数据库名)，执行安装包sql目录qzb.sql文件。
3，用文本编辑器打开config目录下siteconfig.config文件，按提示填写正确的网站域名，链接字符串，AppId等参数；
  为了方便在没有接入公众号的情况下体验程序，我们设置了一个演示模式参数VShopShowMode，请按配置文件里的备注设置；
4，用文本编辑器打开config目录下tenpayconfig.config文件，按备注提示设置微信支付需要的参数

#### 注意事项
1，支持微信登陆，需要在公众号后台设置网页授权回调域名，
公众平台官网中的“开发 - 接口权限 - 网页服务 - 网页帐号 - 网页授权获取用户基本信息”的配置选项中，修改授权回调域名。
按帮助修改即可

2，有关微信支付所必须先开通微信支付商户平台，微信官方的帮助文档有非常详细的说明。

#### 使用指南
后台地址为http://你的域名/backend/admincp.aspx 账号：admin 密码:admin888
微商城地址为http://你的域名/vshop/index.aspx

#### 界面展示
![输入图片说明](https://gitee.com/uploads/images/2018/0611/102010_39acbb3a_1261781.png "1.png")
![输入图片说明](https://gitee.com/uploads/images/2018/0611/102031_545515c3_1261781.png "2.png")
