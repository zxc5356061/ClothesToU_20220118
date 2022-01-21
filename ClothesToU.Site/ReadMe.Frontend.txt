## Keywords
<ul>
<li>ABC</li>
</ul>
<hr>

# MemberService
## New Member Register
<br>
## Member Login
<br>
## Forgot Password
<br>
## Update Member data

<hr>
## New Member Register
<ul>
<li>[v] add /Models/EFModels/AppDbContext</li>
<li>[v] add /Models/Core/ViewModels/RegisterVM</li>

<li>[v] add /Models/UseCases/RegisterRequest class</li>
<li>[v] add /Models/Entities/RegisterEntity class</li>

<li>[v] add Controllers/MembersController/</li>
<li>[] add /Models/UseCases/RegisterCommand class( with Execute method)</li>
<li>[] add /Models/UseCases/RegisterResponse class</li>
<li>[] add /Models/Core/MemberService class(with CreateNewMember method)</li>
<li>[] implement MembersController.Register() function</li>
<li>[] implement RegisterCommand.Execute function</li>
add IMemberRepository
add MemberRepository
	public bool IsExist(string account)
	void Create(MemberEntity entity);
add public static class HashUtility
<li>[] add new /Models/Infrastructures/Repositories/MemberRepository</li>
</ul>

<hr>
## Member Login

<hr>
## Forgot Password

<hr>

Remove Backend Site