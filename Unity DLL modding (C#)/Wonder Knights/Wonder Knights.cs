//dfGUIManager
public void OnGUI()
{
		WK.OnGUI();
}

//B1PlayerData
public void IncreaseGold(int gold)
public void IncreaseCash(int cash)
public void IncreaseIAPCash(int cash)

MonoSingleton<B1GameClient>.Instance.Player.IncreaseCash(num2);

//Value adder
if (GUI.Button(new Rect(NewBehaviourScript.wRect.x + 40f, NewBehaviourScript.wRect.y + 115f, 210f, 40f), "<size=16>Add 10k gold</size>"))
{
		MonoSingleton<B1GameClient>.Instance.Player.IncreaseGold(10000);
}
if (GUI.Button(new Rect(NewBehaviourScript.wRect.x + 40f, NewBehaviourScript.wRect.y + 160f, 210f, 40f), "<size=16>Add 200 gems</size>"))
{
		MonoSingleton<B1GameClient>.Instance.Player.IncreaseCash(100);
		MonoSingleton<B1GameClient>.Instance.Player.IncreaseIAPCash(100);
}
		
//B1CharacterData
		
//CharAtk
//CharCriticalDamagePercent
//CharCriticalPercent
if (WK.toggle1)
{
		return 9999999;
}
				
//CharHP
//TotalHP
if (WK.toggle2)
{
		return 9999999;
}