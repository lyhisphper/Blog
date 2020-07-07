# 常用函数
```
// 获取当前时间
time.Now()

// http 错误提示
http.Error(c.Ctx.ResponseWriter, "Method Not Allowed", http.StatusMethodNotAllowed)

// 提前终止执行逻辑
func (this *RController) Prepare(){
this.StopRun()
}

// 获取请求参数
this.GetString("jsoninfo")

// 写入字符串到响应内容
c.Ctx.WriteString("jsoninfo is empty")

// strconv：字符串和数值类型的相互转换
Itoa()：整型转字符串
Atoi()：字符串转整型

// 数据绑定
var id int
this.Ctx.Input.Bind(&id, "id")  //id ==123

var isok bool
this.Ctx.Input.Bind(&isok, "isok")  //isok ==true

var ft float64
this.Ctx.Input.Bind(&ft, "ft")  //ft ==1.2

ol := make([]int, 0, 2)
this.Ctx.Input.Bind(&ol, "ol")  //ol ==[1 2]

ul := make([]string, 0, 2)
this.Ctx.Input.Bind(&ul, "ul")  //ul ==[str array]

user struct{Name}
this.Ctx.Input.Bind(&user, "user")  //user =={Name:"astaxie"}

// 验证表单
	// 数据验证
	var name = c.GetString("name")
	println(name)
	var age, _ = c.GetInt("age")
	u := User{name, age}
	valid := validation.Validation{} // 实例化验证器

	//验证
	valid.Required(u.Name, "name")
	valid.MaxSize(u.Name, 15, "nameMax")
	valid.Range(u.Age, 0, 18, "age").Message("年龄只能在0-18之间")
	if valid.HasErrors() {
		// 如果有错误信息，证明验证没通过
		// 打印错误信息
		for _, err := range valid.Errors {
			c.Data["json"] = err.Message
			c.ServeJSON()
			c.StopRun()
		}
	}

// 日志
beego.Emergency("this is emergency")
beego.Alert("this is alert")
beego.Critical("this is critical")
beego.Error("this is error")
beego.Warning("this is warning")
beego.Notice("this is notice")
beego.Informational("this is informational")
beego.Debug("this is debug")

// 字段声明
//博文表
type Blog struct {
	BlogId int `orm:"pk;auto;unique;column(blog_id)" json:"blog_id"`
	//文章标题
	BlogTitle string `orm:"column(blog_title);size(500)" json:"blog_title"`
	//文章标识
	BlogIdentify string `orm:"column(blog_identify);size(100);unique" json:"blog_identify"`
	//排序序号
	OrderIndex int `orm:"column(order_index);type(int);default(0)" json:"order_index"`
	//所属用户
	MemberId int `orm:"column(member_id);type(int);default(0);index" json:"member_id"`
	//用户头像
	MemberAvatar string `orm:"-" json:"member_avatar"`
	//文章类型:0 普通文章/1 链接文章
	BlogType int `orm:"column(blog_type);type(int);default(0)" json:"blog_type"`
	//链接到的项目中的文档ID
	DocumentId int `orm:"column(document_id);type(int);default(0)" json:"document_id"`
	//文章的标识
	DocumentIdentify string `orm:"-" json:"document_identify"`
	//关联文档的项目标识
	BookIdentify string `orm:"-" json:"book_identify"`
	//关联文档的项目ID
	BookId int `orm:"-" json:"book_id"`
	//文章摘要
	BlogExcerpt string `orm:"column(blog_excerpt);size(1500)" json:"blog_excerpt"`
	//文章内容
	BlogContent string `orm:"column(blog_content);type(text);null" json:"blog_content"`
	//发布后的文章内容
	BlogRelease string `orm:"column(blog_release);type(text);null" json:"blog_release"`
	//文章当前的状态，枚举enum(’publish’,’draft’,’password’)值，publish为已 发表，draft为草稿，password 为私人内容(不会被公开) 。默认为publish。
	BlogStatus string `orm:"column(blog_status);size(100);default(publish)" json:"blog_status"`
	//文章密码，varchar(100)值。文章编辑才可为文章设定一个密码，凭这个密码才能对文章进行重新强加或修改。
	Password string `orm:"column(password);size(100)" json:"-"`
	//最后修改时间
	Modified time.Time `orm:"column(modify_time);type(datetime);auto_now" json:"modify_time"`
	//修改人id
	ModifyAt       int    `orm:"column(modify_at);type(int)" json:"-"`
	ModifyRealName string `orm:"-" json:"modify_real_name"`
	//创建时间
	Created    time.Time `orm:"column(create_time);type(datetime);auto_now_add" json:"create_time"`
	CreateName string    `orm:"-" json:"create_name"`
	//版本号
	Version int64 `orm:"type(bigint);column(version)" json:"version"`
	//附件列表
	AttachList []*Attachment `orm:"-" json:"attach_list"`
}


```