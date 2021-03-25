--[["
	desc: manager define
	author: oyxz
	since: 2016-04-22
	copyright: xingchen
"]]

local Define = {}

-- 公共模块定义
Define.Tween 	= "Tween"
Define.Window 	= "Window"
Define.Effect 	= "Effect"
Define.Debug 	= "Debug"
Define.Config 	= "Config"
Define.Data 	= "Data"
Define.Lang 	= "Lang"
Define.Scene 	= "Scene"
Define.Game 	= "Game"
Define.ModelRT 	= "ModelRT"
Define.Cache 	= "Cache"
Define.Tips		= "Tips"
Define.Resource	= "Resource"
Define.Http		= "Http"

Define.CoreManages = {
	-- NOTICE: 不可以跳号,处理时会保证时序执行
	-- 基础模块
	[1] = 	{load=1, name="Tween", 				path="mgr.TweenMgr",			mgr="tweenMgr"				},
	[2] = 	{load=1, name="Config", 			path="mgr.ConfigMgr",			mgr="configMgr"				},
	[3] = 	{load=1, name="Lang", 				path="mgr.LangMgr",				mgr="langMgr"				},
	[4] = 	{load=1, name="Resource", 			path="mgr.ResourceMgr",			mgr="resourceMgr"			},
	[5] = 	{load=1, name="Effect", 			path="mgr.EffectMgr",			mgr="effectMgr"				},
	[6] = 	{load=1, name="ModelRT", 			path="mgr.ModelRTMgr",			mgr="modelRTMgr"			},
	[7] =	{load=1, name="Window", 			path="mgr.WindowMgr",			mgr="windowMgr"				},
	[8] =	{load=1, name="Http", 				path="mgr.HttpMgr",				mgr="httpMgr"				},
	[9] = 	{load=2, name="Data", 				path="mgr.DataMgr",				mgr="dataMgr"				},
	[10] = 	{load=2, name="Scene", 				path="scene.SceneMgr",			mgr="sceneMgr"				},
	[11] = 	{load=2, name="Game", 				path="game.GameMgr",			mgr="gameMgr"				},
	[12] = 	{load=2, name="Cache", 				path="mgr.CacheMgr",			mgr="cacheMgr"				},
	[13] = 	{load=2, name="Tips", 				path="mgr.TipsMgr",				mgr="tipsMgr"				},
	[14] = 	{load=2, name="RedDot", 			path="mgr.RedDotMgr",			mgr="redDotMgr"				},

	-- add more
}




--scene层 功能模块定义
Define.SceneManages = {
	-- NOTICE: 不可以跳号,处理时会保证时序执行
	[1] = 	{name="CameraMgr"		,		path="scene.mgr.CameraMgr"		,		mgr="cameraMgr"				},
	[2] =	{name="EntityMgr"		,		path="scene.mgr.EntityMgr"		,		mgr="entityMgr"				},
	[3] = 	{name="InputMgr"		,		path="scene.mgr.InputMgr"		,		mgr="inputMgr"				},
	[4] = 	{name="AudioMgr"		,		path="scene.mgr.AudioMgr"		,		mgr="audioMgr"				},
	[5] = 	{name="EventMgr"		,		path="scene.mgr.EventMgr"		,		mgr="eventMgr"				},
	[6] = 	{name="AiMgr"			,		path="scene.mgr.AiMgr"			,		mgr=nil						},
	[7] = 	{name="SpriteMgr"		,		path="scene.mgr.SpriteMgr"		,		mgr=nil						},
	[8] = 	{name="AreaMgr"			,		path="scene.mgr.AreaMgr"		,		mgr="areaMgr"				},
	[9] = 	{name="GroupMgr"		,		path="scene.mgr.GroupMgr"		,		mgr="groupMgr"				},
	[10] = 	{name="MapMgr"			,		path="scene.mgr.MapMgr"			,		mgr="mapMgr"				},
	[11] = 	{name="DungeonMgr"		,		path="scene.mgr.DungeonMgr"		,		mgr="dungeonMgr"			},
	[12] = 	{name="SpeakMgr"		,		path="scene.mgr.SpeakMgr"		,		mgr=nil						},
	[13] = 	{name="TouchMgr"		,		path="scene.mgr.TouchMgr"		,		mgr=nil						},
	[14] = 	{name="SelectMgr"		,		path="scene.mgr.SelectMgr"		,		mgr="selectMgr"				},
	[15] = 	{name="FollowMgr"		,		path="scene.mgr.FollowMgr"		,		mgr="followMgr"				},
	[16] = 	{name="StoryMgr"		,		path="scene.mgr.StoryMgr"		,		mgr="storyMgr"				},
	[17] = 	{name="AutoFightMgr"	,		path="scene.mgr.AutoFightMgr"	,		mgr="autoFightMgr"			},

}



--game层 功能模块定义
Define.GameManagerType = {
	Module = 1,
	Common = 2,
	Bag = 3,
	Chat = 4,
	Equip = 5,
	Friend = 6,
	Mail = 7,
	Player = 8,
	Shop = 9,
	Team = 10,
	Scene = 11,
	Auction = 12,
	Market = 13,
	Gang = 14,
	Skill = 15,
	Artifact = 16,
	FamilyFire = 17,
	General = 18,
	Task = 19,
	Npc = 20,
	Activity = 21,
	Bloodline = 22,
	Precious = 23,
	RoleTitle = 24,
	RoleHonour = 25,
	CommerceTask = 26,
	Pet = 27,
	WorldBoss = 28,
	Battlefield = 29,
	Fashion = 30,
	Mount = 31,
	SectBattle = 32,
	RoleInfo = 33,
	InfoPanel = 34,
	Ranking = 35,
	LifeSkill = 36,
	Achievement = 37,
	GangHunt = 38,
	Dan = 39,
	RewardFind = 40,
	ClimeTower = 41,
	WelfareOffline = 42,
	DigTreasure = 43,
	AutoTask = 44,
	BabelTower = 45,
	Present = 46,
	Plant = 47,
	WelfareSign = 48,
	WelfareSilver = 49,
	PlayerGuide = 50,
	YanHSingle = 51,
	Enchant = 52,
	OperationActivity = 53,
	TitleContain = 54,
	OperateNotice = 55,
	Customer = 56,
	Ask = 57,
	LatestNews = 58,
	WTEntrance = 59,
	PrivilegeGang = 60,
	ProfTransfer = 61,
	SpanBattle = 62,
	Dance = 63,
	Popup = 64,
	AutoDungeon = 65,
	ZhuXian = 66,
	Wing = 67,
	AlienInvasion = 68,
	AutoPlant = 69,
	Legends = 70,
	Impart = 71,
	OneKey = 72,
	Marry = 73,
	MonsterLair = 74,
	DespairTrial = 75,
	Remind = 76,
	Barrage = 77,
	MysteryStore = 79,
	MountGrowUp = 80,
	GrowUpActivites = 81,
	SoalarrayGrowUp = 82,
	Variant = 83,
	Stall=84,
	Country = 85,
	WheelSurf=86,
	Realm=88,
	CountryWar=89,
}
-- add more

Define.GameManages = {	
	-- 功能模块,init=0时不创建mgr,只创建data
	[Define.GameManagerType.Common]	= {init=0, name="Common"},
	[Define.GameManagerType.Bag]	= {init=1, name="Bag"},	
	[Define.GameManagerType.Chat]	= {init=1, name="Chat"},
	[Define.GameManagerType.Equip]	= {init=1, name="Equip"},
	[Define.GameManagerType.Friend]	= {init=1, name="Friend"},
	[Define.GameManagerType.Mail]	= {init=1, name="Mail"},
	[Define.GameManagerType.Player]	= {init=1, name="Player"},
	[Define.GameManagerType.Shop]	= {init=1, name="Shop"},
	[Define.GameManagerType.Team]	= {init=1, name="Team"},
	[Define.GameManagerType.Scene]	= {init=1, name="Scene"},
	[Define.GameManagerType.Auction]= {init=1, name="Auction"},
	[Define.GameManagerType.Market]	= {init=1, name="Market"},
	[Define.GameManagerType.Skill]	= {init=1, name="Skill"},
	[Define.GameManagerType.Gang]	= {init=1, name="Gang"},	
	[Define.GameManagerType.Artifact] = {init=1, name="Artifact"},
	[Define.GameManagerType.FamilyFire]	= {init=1, name="FamilyFire"},
	[Define.GameManagerType.General]	= {init=1, name="General"},
	[Define.GameManagerType.Task]	= {init=1, name="Task"},	
	[Define.GameManagerType.Npc]	= {init=1, name="Npc"},
	[Define.GameManagerType.Activity]	= {init=1, name="Activity"},	
	[Define.GameManagerType.Bloodline]= {init=1, name="Bloodline"},
	[Define.GameManagerType.RoleTitle]= {init=1, name="RoleTitle"},
	[Define.GameManagerType.RoleHonour]= {init=1, name="RoleHonour"},
	[Define.GameManagerType.Precious] = {init=1, name="Precious"},
	[Define.GameManagerType.CommerceTask] = {init=1, name="CommerceTask"},
	[Define.GameManagerType.Pet] = {init=1, name="Pet"},
	[Define.GameManagerType.WorldBoss] = {init=1, name="WorldBoss"},
	[Define.GameManagerType.Battlefield] = {init=1, name="Battlefield"},
	[Define.GameManagerType.Fashion] = {init=1, name="Fashion"},
	[Define.GameManagerType.Mount] = {init=1, name="Mount"},
	[Define.GameManagerType.SectBattle] = {init=1, name="SectBattle"},
	[Define.GameManagerType.RoleInfo] = {init=1, name="RoleInfo"},
	[Define.GameManagerType.InfoPanel] = {init=1, name="InfoPanel"},
	[Define.GameManagerType.Ranking] = {init=1, name="Ranking"},
	[Define.GameManagerType.LifeSkill] = {init=1, name="LifeSkill"},
    [Define.GameManagerType.Achievement] = {init=1, name="Achievement"}, 
	[Define.GameManagerType.GangHunt] = {init=1, name="GangHunt"},
	[Define.GameManagerType.Dan] = {init=1, name="Dan"},
	[Define.GameManagerType.ClimeTower] = {init=1, name="ClimeTower"},
	[Define.GameManagerType.RewardFind] = {init=1, name="RewardFind"},
	[Define.GameManagerType.WelfareOffline] = {init=1, name="WelfareOffline"},
	[Define.GameManagerType.DigTreasure] = {init=1, name="DigTreasure"},
	[Define.GameManagerType.AutoTask] = {init=1, name="AutoTask"},
	[Define.GameManagerType.BabelTower] = {init=1, name="BabelTower"},
	[Define.GameManagerType.Present] = {init=1, name="Present"},
	[Define.GameManagerType.Plant] = {init=1, name="Plant"},
	[Define.GameManagerType.WelfareSign] = {init=1, name="WelfareSign"},
	[Define.GameManagerType.WelfareSilver] = {init=1, name="WelfareSilver"},
	[Define.GameManagerType.PlayerGuide] = {init=1, name="PlayerGuide"},
	[Define.GameManagerType.YanHSingle] = {init=1, name="YanHSingle"},
	[Define.GameManagerType.Enchant] = {init=1, name="Enchant"},
	[Define.GameManagerType.OperationActivity] = {init=1, name="OperationActivity"},
	[Define.GameManagerType.TitleContain] = {init=1, name="TitleContain"},
	[Define.GameManagerType.OperateNotice] = {init=1, name="OperateNotice"},
	[Define.GameManagerType.Customer] = {init=1, name="Customer"},
	[Define.GameManagerType.Module] = {init=1, name="Module"},
	[Define.GameManagerType.Ask] = {init=1, name="Ask"},
	[Define.GameManagerType.LatestNews] = {init=1, name="LatestNews"},
	[Define.GameManagerType.WTEntrance] = {init=1, name="WTEntrance"},
	[Define.GameManagerType.PrivilegeGang] = {init=1, name="PrivilegeGang"},
	[Define.GameManagerType.ProfTransfer] = {init=1, name="ProfTransfer"},
	[Define.GameManagerType.SpanBattle] = {init=1, name="SpanBattle"},
	[Define.GameManagerType.Dance] = {init=1, name="Dance"},
	[Define.GameManagerType.Stall] = {init=1, name="Stall"},
	[Define.GameManagerType.Popup] = {init=1, name="Popup"},
	[Define.GameManagerType.AutoDungeon] = {init=1, name="AutoDungeon"},
	[Define.GameManagerType.ZhuXian] = {init=1, name="Zhuxian"},
	[Define.GameManagerType.Wing] = {init=1, name="Wing"},
	[Define.GameManagerType.AlienInvasion] = {init=1, name="AlienInvasion"},
	[Define.GameManagerType.AutoPlant] = {init=1, name="AutoPlant"},
	[Define.GameManagerType.Legends] = {init=1, name="XuanYuanLegends"},
	[Define.GameManagerType.Impart] = {init=1, name="Impart"},
	[Define.GameManagerType.OneKey] = {init=1, name="OneKey"},
	[Define.GameManagerType.Marry] = {init=1, name="Marry"},
	[Define.GameManagerType.MonsterLair] = {init=1, name="MonsterLair"},
	[Define.GameManagerType.DespairTrial] = {init=1, name="DespairTrial"},
	[Define.GameManagerType.Remind] = {init=1, name="Remind"},
	[Define.GameManagerType.Barrage] = {init=1, name="Barrage"},
	[Define.GameManagerType.MysteryStore] = {init=1, name="MysteryStore"},
	[Define.GameManagerType.MountGrowUp] = {init=1, name="MountGrowUp"},
	[Define.GameManagerType.GrowUpActivites] = {init=1, name="GrowUpActivites"},
	[Define.GameManagerType.SoalarrayGrowUp] = {init=1, name="SoalarrayGrowUp"},
	[Define.GameManagerType.Variant] = {init=1, name="Variant"},
	[Define.GameManagerType.Country] = {init=1,name="Country"},
	--[Define.GameManagerType.WheelSurf]={init=0,name="WheelSurf"}
	[Define.GameManagerType.Realm]	= {init=1, name="Realm"},
	[Define.GameManagerType.CountryWar]	= {init=1, name="CountryWar"},
	-- add more
}

return Define