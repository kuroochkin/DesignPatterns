using Bridge.Programmer;

Programmer freelancer = new FreelanceProgrammer(new CPPLanguage());
freelancer.DoWork();
freelancer.EarnMoney();
// пришел новый заказ, но теперь нужен c#
freelancer.Language = new CSharpLanguage();
freelancer.DoWork();
freelancer.EarnMoney();