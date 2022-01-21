*** MemberService ***
## [v] New Member Register
## [working] Member Login
## [] Forgot Password
## [] Update Member data
## [] MemberData CRUD
======================

## New Member Register
[v] add /Models/EFModels/AppDbContext

[v] add /Models/Core/ViewModels/RegisterVM
		-public string Account { get; set; }
		-public string Password { get; set; }
		-public string ConfirmPassword { get; set; }
		-public string Name { get; set; }
		-public string Mobile { get; set; }
		-public string Address { get; set; }

[v] add /Models/UseCases/RegisterRequest class
		-public string Account { get; set; }
		-public string Password { get; set; }
		-public string Name { get; set; }
		-public string Mobile { get; set; }
		-public string Address { get; set; }

[v] add /Models/UseCases/RegisterResponse class
		-public bool IsSuccess { get; set; }
		-public string ErrorMessage { get; set; }
		-public RegisterEntity Data { get; set; }

[v] add /Models/Entities/RegisterEntity class
		-public string Account { get; set; }
		-public string Password { get; set; }
		-public string Name { get; set; }
		-public string Mobile { get; set; }
		-public string Address { get; set; }
		-public string ConfirmCode { get; set; }
		-public const string SALT = "!@#";
		-public string EncryptedPassword { get; }

[v] add /Models/Extensions
		-RegisterEntityExt
			public static Member ToEFMember(this RegisterEntity source)
		-RegisterRequestExt
			public static RegisterEntity ToRegisterEntity(this RegisterRequest source)
		-RegisterVMExt
			public static RegisterRequest ToRegisterRequest(this RegisterVM source)

[v] add /Models/Core/MemberServices
		-public RegisterResponse CreateNewMember(RegisterRequest request)

[v] add /Controllers/MembersController/
		-public ActionResult Index()
		-public ActionResult Register()
		-[HttpPost]public ActionResult Register(RegisterVM registerVM)

[v] add /Models/UseCases/RegisterCommand class( with Execute method)
		-public RegisterResponse Execute(RegisterVM registerVM)

[v] add IRegisterRepository & RegisterRepository
		-bool IsExist(string account);
		-void Create(RegisterEntity entity);

[v] add /Views/Members/Register.cshtml(create)
[v] add /Views/Members/Register.cshtml(empty)
======================

## Member Login