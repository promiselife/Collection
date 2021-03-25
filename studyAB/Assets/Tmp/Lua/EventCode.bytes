--[["
	desc: 事件定义类
	author: oyxz
	since: 2015-09-25
	copyright: xingchen
 "]]

local EventCode = {}

-- 所有模块间通信时需要用到的事件定义,包括C#层的事件id值
-- c#层的事件id预留了1000以内的id号段
--   <500内为lua与c#交互用,500~1000为c#层自用事件id
-- lua层的事件上id从1000开始

-- from c# code
EventCode.Core = {
	-- NOTICE: id不可以更改,因为lua层也有引用,切记,有修改时需要通知lua层	
	-- id段为1~500
	OnNoneEvent			= 0,
	-- 显示信息
	OnShowMsg			= 1,
	OnErrorCode			= 2,

	-- 前后台切换
	OnPause				= 3,	-- 切到后台
	OnResume 			= 4,    -- 切到前台

	OnLoginWindow		= 5,	-- 登陆界面
	OnRoleWindow 		= 6,	-- 角色界面
	OnLoadingWindow 	= 7,   	-- 加载界面
	OnQuitWindow 		= 8,    -- 退出提示界面
	
	OnConnectInfo 		= 10,	-- 登录游戏信息
	OnNetError     		= 11,	
	OnNetChange 		= 12,	-- 网络切换

	OnSceneLoaded       = 13,

	-- lua view
	OnViewAwake			= 14,
	OnViewEnable		= 15,
	OnViewDisable		= 16,
	OnViewDestroy		= 17,

	-- camera
	OnShakeCamera		= 18,

	-- voice
	OnVoiceMessage 		= 19,	-- 语音消息通知	
	OnMicLevelChange	= 20,

	-- test
	OnTestRecvPush		= 21,	-- 测试push消息
	OnTestRecvAoi		= 22,	-- 测试aoi消息

	-- sdk
	OnSdkLoginCallback	= 23,	-- 登录回调
	OnSdkLogoutCallback = 24,   -- 注销回调
	OnSdkPayCallback 	= 26,   -- 支付回调


	OnLoginCode 		= 27,   -- 打开注册
	OnRegisterResponse 	= 28,   -- 关闭注册
	
	OnChangePWDResponse = 29,   -- 修改密码回调
	
	
	OnHttpResponse 		= 30,   -- 回调http消息

	-- resources
    OnResourceLoaded    = 40,
    OnAllResourcesDownloaded = 42,
    OnAllResourcesDownloadFailed = 43,

    OnFpsUpdate 		= 45,	--fps信息更新

	-- entity
	OnRoleCreate		= 51,	-- 专门给EntityMgr内使用,其它不允许使用
	OnRoleClear			= 52,	-- 专门给EntityMgr内使用,其它不允许使用	
	OnRoleRemove 		= 53,
	OnRoleDamage 		= 54,

	OnTouchEntity 		= 55,
	OnTouchGround		= 56,	-- 专门给InputMgr内使用,其它不允许使用	

    OnHeroOutlookChange = 57,
	OnHeroCosplay		= 58, --进入变身
	OnHeroCosplayRevert	= 59, --退出变身
	
	OnFightBackUpdate	= 60,
	OnHeroMoveEnd		= 61,
	OnHeroTransmited 	= 62, --主角传送 专门给EntityMgr内使用,其它不允许使用

	OnChangeSceneEnd    = 63, --切换地图结束
	OnEntityDead    	= 64, --用于单机通知lua 某个实体被谁杀死 {死亡eid 击败eid}
	OnDeputyCreate		= 65,

	-- add more ...
	OnStopAI			= 100,

	OnBossBeAttack		= 101,--//用于Boss头像震动

	OnChangeJumpCamera	= 102, --跳跃过程中改变摄像机参数
	OnTouchScreen = 103, --点击屏幕播放特效

	OnTitleHideStateChange = 104, --隐藏 玩家 称号

	OnShowMessageTips = 107,  --显示提示信息
	OnObjectLoadEnd = 108,  --Object加载完成
	-- 当前最大的id值定义
	OnLastEventId		= 500,

}

local START_ECODE = 1000
EventCode.Logic = START_ECODE

-- 公共基础模块,号段<100
EventCode.Common = {
	-- OnUpdateAttrData    = START_ECODE + 1,			-- lua层数据更新
	OnUpdatePosData     = START_ECODE + 2,			-- 实体座标数据更新
	OnCreateEntity      = START_ECODE + 3,			-- lua层实体创建协议
	OnUpdateLevel      	= START_ECODE + 4,			-- lua层等级更新
	OnUpdateHp 			= START_ECODE + 5,			-- lua层血量更新
	OnUpdateVipLevel	= START_ECODE + 6,			-- lua层vip等级更新
	OnUpdateDiamond		= START_ECODE + 7,			-- lua层钻石更新
	OnUpdateGold		= START_ECODE + 8,			-- lua层金钱更新
	OnUpdateExp			= START_ECODE + 9,			-- lua层经验更新
	OnAfterFlowEvent    = START_ECODE + 10,			-- 界面层切图成功后协议分发点
	OnUpdateRecharge 	= START_ECODE + 11, 		-- lua层充值钻石更新
	OnHeroCreate		= START_ECODE + 12, 		-- 主角创建完成
	OnUpdateBattle		= START_ECODE + 13,			-- lua层战力更新
	OnUpdatePro 		= START_ECODE + 14,			-- lua层职业
	OnHeroBuffUpdate    = START_ECODE + 15,			-- lua层数据 buff列表更新
	OnHeroPropUpdate 	= START_ECODE + 16,			-- 主角实体属性更新
	OnCalculatorNum     = START_ECODE + 17,         -- 计算器当前计算值
	OnCalculatorDelete  = START_ECODE + 18,         -- 计算器删除上一位当前计算值
	OnCloseCalculator   = START_ECODE + 19,         -- 关闭计算器
	OnUpdateVipExp		= START_ECODE + 20,         -- lua层Vip经验
	OnHeroLvSync		= START_ECODE + 21,         -- lua层初始等级同步通知

	OnChangeServerDay	= START_ECODE + 22,         -- lua层服务器天数变更通知
	OnChangeServerLvl	= START_ECODE + 23,         -- lua层服务器等级变更通知
	OnLayerContentChange= START_ECODE + 24,			-- ui 层内容变化

	OnCurrencyChange	= START_ECODE + 25,			-- 货币变化
	OnUpdateErrantry	= START_ECODE + 26,			-- lua层侠义值更新

	OnHideNpcTalkWidget = START_ECODE + 27,			-- 隐藏npc对话面板
	OnRedDotOverTime 	= START_ECODE + 28,			-- 红点刷新,到达次日凌晨4点
	OnUpdateBattleFieldPoint = START_ECODE + 29,	-- lua层跨服战场积分更新
	OnEntityObjectLoadEnd= START_ECODE + 31,--实体的模型加载完毕（不加载模型 xnm）
	--OnUpdateCountry		= START_ECODE + 30,			--lua层国家
}

-- 只在场景层进行处理
EventCode.Scene = {	
	OnClearMonsterGroup	= START_ECODE + 51,
	OnSpawnMonsterGroup	= START_ECODE + 52,
	OnRemoveMonsterGroup = START_ECODE + 53,	

	OnClearDoodadGroup	= START_ECODE + 54,
	OnSpawnDoodadGroup	= START_ECODE + 55,
	OnRemoveDoodadGroup	= START_ECODE + 56,

	-- joystick control
	OnJoystickChange	= START_ECODE + 57,
	OnNormalSkillDowning= START_ECODE + 58,
	OnSkillBtnClick 	= START_ECODE + 59,
	OnSlideBtnClick		= START_ECODE + 60,
	OnHeroInput			= START_ECODE + 61,

	--点击地面
	OnTouchGround 		= START_ECODE + 62,

	--OnClearNpcGroup	= START_ECODE + 63,
	OnSpawnNpcGroup	= START_ECODE + 64,
	OnRemoveNpcGroup = START_ECODE + 65,
	
	OnClearPlantGroup	= START_ECODE + 66,
	OnSpawnPlantGroup	= START_ECODE + 67,
	OnRemovePlantGroup = START_ECODE + 68,

	OnEnterSafeArea = START_ECODE + 69,
	OnExitSafeArea = START_ECODE + 70,

	OnEnterDoodadArea = START_ECODE + 71,
	OnExitDoodadArea = START_ECODE + 72,

	OnCreateArea = START_ECODE + 73,
	OnCreateEvent = START_ECODE + 74,

	OnTriggerCondition = START_ECODE + 75,

	OnEventGroupWillChange = START_ECODE + 76,
	OnEventGroupChanged = START_ECODE + 77,

	OnPhaseModeChanged = START_ECODE + 78,

	OnRemoveArea = START_ECODE + 79,
	OnRemoveAreaEvent = START_ECODE + 80,

	--采集物cd更新
	OnUpdatePlantCD = START_ECODE + 81,

	OnJoystickDrag 	= START_ECODE + 82,
	OnJoystickUp 	= START_ECODE + 83,

	OnEnterArena = START_ECODE + 84,
	OnExitArena = START_ECODE + 85,

	OnCheckCondition = START_ECODE + 86,

	OnStoryModeChanged = START_ECODE + 87,

	OnSpawnConfigMonster = START_ECODE + 88,

	OnTouchGroundMove = START_ECODE + 89,

	OnHeroEnterScene = START_ECODE + 90,	--主角进入场景
	OnHeroAreaChange = START_ECODE + 91,	-- 主角区域变更

	OnCollectPlantGroup = START_ECODE + 92, --采集物组被采集

	OnSceneTransmit = START_ECODE + 93, --同地图传送

	OnEntityBehavior = START_ECODE + 94, --实体行为通知

	OnJoyDragStatus = START_ECODE + 95, --摇杆按下状态

	OnEnterWitnessArena = START_ECODE + 96, --进入观战区
	OnExitWitnessArena = START_ECODE + 97, --离开观战区

	OnUIMoveToView = START_ECODE + 98,
	OnUIMoveInView = START_ECODE + 99,

	OnLockInput = START_ECODE + 100, --锁定输入

	OnInOUTStallArea=START_ECODE + 130,--进出摆摊区域
	
}

EventCode.Bag = {
	OnUpdateItemEvent = START_ECODE + 101,		-- 刷新道具
	-- OnAutoUseTips = START_ECODE + 102,	--自动提示道具tips
	OnBagRedDotPrompt = START_ECODE + 103,	--背包红点提示

	OnSendBeadUse = START_ECODE + 104,	--使用修炼珠
	OnUpdatePracticeTime = START_ECODE + 105,	--更新修炼时间
	OnUpdatePracticeItem = START_ECODE + 106,	--更新使用修炼丹次数

	OnUpdateArtifactEvent = START_ECODE + 107, --刷新神器
	OnUpdateEquipmentEvent = START_ECODE + 108, --刷新普装
	OnUpdateJadeEvent = START_ECODE + 109, --镶嵌成功普装
	OpenJadePanel = START_ECODE + 110, --打开镶嵌

	OnShowBagAutoTips = START_ECODE + 111, --显示主背包中有自动提示的物品
	OnCheckBagAutoTips = START_ECODE + 112, --检查自动提示的物品

	OpenBagEquipmentPanel = START_ECODE + 113, --打开对应信息
	OnSendPracticeId = START_ECODE + 114, --发送修炼物品id
	OnUpdateUseGoodsInfo = START_ECODE + 115,  --物品使用情况更新

	OnTipsScaleComplete = START_ECODE + 116, --tips缩放完毕
	OnEquipmentSuccess = START_ECODE + 117, --强化镶嵌成功 播放特效
	OnArtifactPutOnEffect = START_ECODE + 118, --核装穿上特效

	OnCloseUseTips = START_ECODE + 119, --关闭快捷使用

	OnShowItemGetText = START_ECODE + 120, --获得物品飘字

	OnUpdatePracticeTips = START_ECODE + 121, --刷新修炼tips Buff
	OnUpdatePracticeTeam = START_ECODE + 122, --获取修炼地队伍id

	OnBagWeaponChange = START_ECODE + 123, --背包中的武器变化
	OnBagClothChange = START_ECODE + 124, --背包中的衣服变化
	OnBagTreasureUse = START_ECODE + 125, --快捷实用背包藏宝图
	OnAddMaterial = START_ECODE + 126, --普装强化材料刷新--增加
	OnMianEquipChange = START_ECODE + 127, --主背包中的普装变化
	OnRemoveMaterial = START_ECODE + 128, --材料删除
	OnMianEquipAddDel = START_ECODE + 129, --主背包中的普装增加删除
	OnPetUnrealChange = START_ECODE + 129,--皮肤幻化果变化
	OnEngraveSuccess=START_ECODE+130,--铭刻完毕
	OnIdentifySuccess=START_ECODE+131,--鉴定完毕
	OnCompoundItemSuccess=START_ECODE+132,--道具合成完毕
}

EventCode.Role = {
	OnRoleTitleUpdate		= START_ECODE + 200, -- 刷新title
	OnRoleHpUpdate 			= START_ECODE + 201, -- 刷新属性-hp
	OnHeroHpUpdate 			= START_ECODE + 202, -- 刷新属性-hp-hero
	OnHeroRageUpdate 		= START_ECODE + 203, -- 刷新属性-rage-hero
	OnHeroPosUpdate			= START_ECODE + 204, -- 刷新属性-pos-hero

	OnRoleDeaded 			= START_ECODE + 205, -- 实体死亡
	OnRoleRevive 			= START_ECODE + 206, -- 实体复活
	OnRolePrepared			= START_ECODE + 207, -- 实体已准备好（出场完毕）

	-- CD
	OnHeroStartCD 			= START_ECODE + 209,
	OnHeroEndCD  			= START_ECODE + 210,

	--A by Wenmin.Yu, 2016-12-01
	OnRoleVisibleUpdated 	= START_ECODE + 211, --实体可见性发生更新


	OnPlayerDataUpdate		= START_ECODE + 213, -- 刷新player data

	OnRoleSpeak				= START_ECODE + 214, -- 实体喊话

	OnGroupFightStateChange = START_ECODE + 215, -- 组战斗状态变化

	OnFightStateChange		= START_ECODE + 216, -- 战斗状态变化

	OnHeroPkModeUpdate		= START_ECODE + 217, -- 刷新属性-pkmode-hero

	OnSendHeroRevive		= START_ECODE + 218, -- 发送主角复活

	OnClearHate				= START_ECODE + 219, -- 清仇恨值
	OnBehateData			= START_ECODE + 220, -- 添加被仇眼值

	OnHeroAreaUpdate		= START_ECODE + 221, -- 主角区域变化

	OnHeroNearNpc			= START_ECODE + 222, -- 主角靠近NPC
	OnHeroOutNpc			= START_ECODE + 223, -- 主角离开NPC
	OnHeroNearPlant			= START_ECODE + 224, -- 主角靠近植物
	OnHeroOutPlant			= START_ECODE + 225, -- 主角离开植物

	OnDoodadInout			= START_ECODE + 226, -- 进出doodad

	OnLevelUp				= START_ECODE + 227, -- 手动升级

	OnHeroHpNotify			= START_ECODE + 228, -- 主角血量变更通知
	OnHeroBehitNotify		= START_ECODE + 229, -- 主角受击通知
	OnHeroEnterSprint		= START_ECODE + 230, -- 主角进入冲刺状态

	-- 231~250 主角keyvalue 更新
	OnHeroKeyValueTeamId	= START_ECODE + 231, -- 主角组队id变化
	OnHeroKeyValueGangId	= START_ECODE + 232, -- 主角宗派id变化
	OnHeroKeyValueTitleId	= START_ECODE + 233, -- 称号id变化
	OnHeroKeyValueHonourId	= START_ECODE + 234, -- 头衔id变化
	-- OnHeroKeyValueEvil		= START_ECODE + 235, -- 罪恶值变化
	OnHeroKeyValueFightBack	= START_ECODE + 236, -- 反击列表变化
	OnHeroAddExp			= START_ECODE + 237, -- 经验变化
	OnRoleHide				= START_ECODE + 238, -- 隐身状态变化
	OnUpdateName			= START_ECODE + 239, -- 角色名变化
	OnHeroOffRide	  		= START_ECODE + 240, -- 主角主动下坐骑
	OnHeroSoulState 		= START_ECODE + 241, -- 主角灵魂状态变化
	OnHeroSafeArea 			= START_ECODE + 242, -- 主角安全区变化
	OnHeroEnterFight		= START_ECODE + 243, -- 主角进入战斗状态
	OnFollowerFight			= START_ECODE + 244, -- 跟战者攻击目标
	OnHeroKeyValueCampId 	= START_ECODE + 245, -- 主角阵营id变化
	OnHeroForbidSprint	 	= START_ECODE + 246, -- 是否屏蔽冲刺状态变化
	OnHeroKeyValueHp	 	= START_ECODE + 247, -- 血量变化
	OnHeroKeyValueHpMax	 	= START_ECODE + 248, -- 最大血量变化
	OnHeroKeyValueAvatarId	= START_ECODE + 249, -- 头像变化

	--251~270 其他keyvalue 更新
	OnKeyValuePk 			= START_ECODE + 251, -- pk模式变化
	OnKeyValueTeamId 		= START_ECODE + 252, -- 组队id变化
	OnKeyValueGangId		= START_ECODE + 253, -- 宗派id变化
	OnKeyValueTitleId		= START_ECODE + 254, -- 称号id变化
	OnKeyValueHonourId		= START_ECODE + 255, -- 头衔id变化
	OnKeyValueCampId		= START_ECODE + 256, -- 阵营id变化
	OnKeyValueIsPhase		= START_ECODE + 257, -- 相位模式变化
	OnKeyValueName			= START_ECODE + 258, -- 名字变化
	OnKeyValueIsStory		= START_ECODE + 259, -- 剧情模式变化
	OnKeyValueSafeArea 		= START_ECODE + 260, -- 安全区变化
	OnRoleName 				= START_ECODE + 261, -- 名字变化
	OnImpart 				= START_ECODE + 261, -- 传功状态变化
	OnUpdateBattle          = START_ECODE + 261, -- 战力状态变化
	
	--271~280 follow 实体移动完毕回调
	OnFollowNpc				= START_ECODE + 271, -- NPC
	OnFollowMonster			= START_ECODE + 272, -- 怪物
	OnFollowPlant			= START_ECODE + 273, -- 采集物
	OnTrySceneLoad			= START_ECODE + 281, --切图读条
	OnTryInDungeon 			= START_ECODE + 282, --提示副本进入弹框
	OnHeroMoveStateChange   = START_ECODE + 283, --主角移动状态更新
	OnStartAI				= START_ECODE + 284, --开始Ai
	--OnStopAI				= START_ECODE + 285, --停止Ai
	OnStopAI				= EventCode.Core.OnStopAI, --停止Ai	

	OnChangeToTimerHP		= START_ECODE + 286, --切换角色血条为计时血条

	OnRoleHunt				= START_ECODE + 287, --角色造成伤害
	OnComboKill 			= START_ECODE + 288, --连斩

	OnHeroStateToStand		= START_ECODE + 289, --主角切换到站立状态
	OnHeroWillTransmit 		= START_ECODE + 290, --主角将被传送

	OnPauseAI				= START_ECODE + 291, --暂停Ai
	OnResumeAI				= START_ECODE + 292, --恢复Ai

	--A bt Wenmin.Yu, 2017-02-08
	OnSyncHeroAttrs			= START_ECODE + 293, --同步主角属性（仅供lua层模拟C#同步属性数据使用）

	OnHeroHookState			= START_ECODE + 294, --挂机状态
	OnHeroFollowState		= START_ECODE + 295, --跟战状态
	OnHeroChangeMapState    = START_ECODE + 296, --切换地图状态
	OnUpGrade 				= START_ECODE + 297, --升级

	OnHeroTransmited		= START_ECODE + 298, --主角传送完毕

	OnDelHateData			= START_ECODE + 299, --清除仇恨
	OnShowFly				= START_ECODE + 300, --跳跃动作

	OnRoleSkillsUpdated		= START_ECODE + 301, --技能列表发生变化
	OnHeroCosplayUpdated	= START_ECODE + 302, --主角变身发生变化
	OnBreakByEmoji			= START_ECODE + 303, --表情打断
	OnPetRevive				= START_ECODE + 304, --宠物复活

	OnHeroJumpOver			= START_ECODE + 305, --主角跳跃完毕
	OnHeroWillJump			= START_ECODE + 306, --主角将跳跃

	OnStartAIComplete		= START_ECODE + 307, --实体AI启动完毕

	OnPlayerFastBattleChange = START_ECODE + 308, --战力提示快捷操作记录变化
	OnServerIdChange		= START_ECODE + 309, --实体服务器id变更

	OnFollowPathFlagChange	= START_ECODE + 310, --寻路执行标识变化
	OnUnLockDance  			= START_ECODE + 311, --寻路执行标识变化
	OnShowScreenEffect		= START_ECODE + 312, --播放屏幕特效
	OnHeroReleaseSkill		= START_ECODE + 313, --主角释放技能
	
}

-- 聊天信息
EventCode.Chat = {
	OnUpdateChatEvent 		= START_ECODE + 401,
	OnShowNewTrumper		= START_ECODE + 403,
	OnUpdateColorChatCount	= START_ECODE + 404,
	OnUpdateBlackList		= START_ECODE + 405,
	OnOpenPrivateChat		= START_ECODE + 406,
	OnSendHitToChat			= START_ECODE + 407,
	OnShowMsgToChatInput	= START_ECODE + 408,

	--重整解耦
	OnShowLeSetting			= START_ECODE + 410,
	OnShowMailCtrl			= START_ECODE + 411,
	OnUpdatePrivateTager    = START_ECODE + 412,
	OnShowColorInput		= START_ECODE + 413,
	
	--重写后修正事件
	OnShowChatMore			= START_ECODE + 415,
	OnInsertLink			= START_ECODE + 417,
	OnChangeChatShowMark	= START_ECODE + 418,
	OnShowTargetChannel		= START_ECODE + 419,
	OnShowFaceText			= START_ECODE + 420,
	OnGetNetIOfflineData  	= START_ECODE + 422,
	OnSendLinkHitToChat 	= START_ECODE + 423,
	OnValidSpeak			= START_ECODE + 424,
	OnShowSpeak				= START_ECODE + 425,
	OnHideSpeak				= START_ECODE + 426,
	OnSendChatEvent			= START_ECODE + 427,
	OnHideBigChat			= START_ECODE + 428,
	OnSendChannel		= START_ECODE + 429,
	OnChatMoreData			= START_ECODE + 430, --由ChatMore传过来的消息
	OnChangeSceneOpen		= START_ECODE + 431, --外部打开面板
	OnBubbleChange 			= START_ECODE + 432, --聊天框改变
	OnBubbleRedDot 			= START_ECODE + 433, --聊天框设置按钮红点
	OnBubblesOprt			= START_ECODE + 434, --聊天框列表
	OnBubblesInit			= START_ECODE + 435, --聊天框选择初始化
	OnWorldBoard	= START_ECODE + 436, --小喇叭
	OnChatDoTween  =  START_ECODE + 437, --窗口的dotween特效
	OnChatMoreTween  =  START_ECODE + 438, --窗口的dotween特效
	OnCloseMoreWin  =  START_ECODE + 439, --窗口的dotween特效
	OnInitChatWidget  =  START_ECODE + 442, --为chatwidget字段初始化
	OnRefreshTeam  =  START_ECODE + 443, --刷新队伍频道
	OnClosePvtWidget  =  START_ECODE + 444, --关闭私聊小窗口
	OnOpenWindow  =  START_ECODE + 445, --打开社交界面
	OnCostWorldTip  =  START_ECODE + 446, --世界聊天花费
	OnFriMoreTween  =  START_ECODE + 447, --窗口的dotween特效
}

EventCode.Mall = {
	OnUpdateMallType = START_ECODE + 501, -- 刷新当前商城类型
	OnUpdateMallGoodsList = START_ECODE + 502, -- 更新商城商品列表
	OnUpdateMallGoodsLeftTimes = START_ECODE + 503, -- 更新商城商品剩余可购买次数
	OnUpdateMallChargeRed = START_ECODE + 504, -- 更新充值红点
}

EventCode.NewMall = {
	-- OnUpdateWeeklyMallList = START_ECODE + 504,     -- 刷新每周商城类型
	-- OnUpdateMallAllList = START_ECODE + 505,        -- 刷新全部商城类型
	-- OnUpdateMallRechargeList = START_ECODE + 506,   -- 刷新充值列表
	OnUpdateMallNum = START_ECODE + 509,            -- 刷新商城剩余数量
	--OpenMountAndFashionMallPanel = START_ECODE + 513, -- 打开时装坐骑商店
	OpenMallItem = START_ECODE + 514,               -- 打开商城指定物品
	OnVipDotChange = START_ECODE + 516,		
	OnVipGiftChange = START_ECODE + 517,		
	OnNewRedCountChange = START_ECODE + 518,		-- 新品红点数变化
	OpenMallPage = START_ECODE + 519,               -- 打开商城指定页面
	CloseVipCircleTime = START_ECODE + 520,   --关闭转圈界面计时器
	OnVipUpdateDouble = START_ECODE + 521,    --vip双倍数据更新通知
	OnDotChange = START_ECODE + 522, 		 --兑换商店红点刷新
	OpenExchangeMallPage = START_ECODE + 523, --打开兑换商店指定页
	OnSwitchFunc = START_ECODE +524,		--充值与vip特权的切换
}

EventCode.MysteriousShop = {
	OnUpdateData = START_ECODE + 510, -- 刷新神秘商店的数据
	OnUpdateGoodsLeftTimes = START_ECODE + 511, -- 更新神秘商店商品剩余可购买次数
}

EventCode.Friend = {
	--请求协议
	OnAskFriendList  =  START_ECODE + 601 ,    -- 请求好友列表
	OnAskRecommendFriendList = START_ECODE + 602, --请求推荐好友列表
	OnAskApplyToFriends = START_ECODE + 603, --请求发送好友申请
	OnAskAgreeApplication = START_ECODE + 604, --请求同意好友申请
	OnAskClearFriendInvite = START_ECODE + 605, --清空好友申请列表
	OnAskAgreeFriendInvite = START_ECODE + 624 , --键同意好友申请
	OnAskRemoveFriend = START_ECODE + 606, --请求删除好友
	OnAskApplyList     =START_ECODE + 607,   --请求申请列表
	OnAskRemoveEnemy = START_ECODE + 612, --请求删除仇人
	OnAskEnemyList = START_ECODE + 613, --请求仇人列表
	OnAskRevenge = START_ECODE + 614, --请求复仇
	OnPublishWantedReq = START_ECODE + 617, --请求通缉他人
	OnCatchWantedReq = START_ECODE + 618, --请求接取通缉
	OnWantedListReq = START_ECODE + 619,      --请求通缉列表
	OnNotAddFriendReq = START_ECODE	+ 625 ,   --忽略申请列表
	OnAskResentmentList = START_ECODE +627 ,  --请求恩怨谱数据
	OnAskBlackList      =  START_ECODE + 629, --请求黑名单列表
	OnAskAddEnmey       = START_ECODE + 630,  --请求添加仇人
	OnAskAddWorldEnmey       = START_ECODE + 637,  --请求添加仇人
	OnAskSetnotOldEnemy    = START_ECODE +631,   --请求解除宿敌
	OnAskSetOldEnemy        = START_ECODE +632,   --请求设置宿敌
 	--界面更新
	OnUpdateListFriend = START_ECODE + 608, -- 更新好友列表
	OnUpdateRecommendFriend = START_ECODE + 609, -- 更新推荐好友列表
	OnUpdateApplicant = START_ECODE + 610, -- 更新好友申请列表红点
	OnUpdateApplicationList = START_ECODE +  628,  -- 更新好友申请列表
	OnUpdateEnemy = START_ECODE + 611, --更新仇人列表
	OnUpdateRevengeInfo = START_ECODE + 615, --更新复仇信息
	OnUpdateFriendRedDot = START_ECODE + 616, --更新好友申请红点提示
	OnUpdateWantedList = START_ECODE + 620, --更新通缉列表
	OnUpdateWantedInfo = START_ECODE + 621, --更新当前通缉中的信息
	OnOnUpdataAdd      = START_ECODE+622 , --更新好友推荐
	OnSearchFriend     = START_ECODE+623 ,--更新搜索列表
	OnResentmentList   = START_ECODE+633, --更新恩怨簿
	OnResentmentActive       = START_ECODE+634 , --更新敌人活跃列表
	OnNotAppliction       =  START_ECODE +635,  --更新拒绝好友申请按钮
	OnUpdateBlackList      =  START_ECODE + 636, --更新黑名单列表
	OnDelToDoFriend             =  START_ECODE + 639,  -- 好友删除回调
	OnDelToDoEnemy              =  START_ECODE + 640,  --敌人删除回调
	OnResnetRodTips              =  START_ECODE + 641,  --敌人删除回调
	OnOpenTitleBtn              =  START_ECODE + 642,  --被动打开指定界面
	OnDeluieveEve            =  START_ECODE + 643,  --清空好友消息回调
	OnDelPvtData            =  START_ECODE + 644,  --删除联系人回调
	OnOpenSubBtn             =  START_ECODE + 665,  --被动打开社交界面
}

EventCode.Mail = {
	OnUpdateMailEvent = START_ECODE + 701, --邮件数据更新
	OnUpdateMailRedDots = START_ECODE + 702, --邮件红点更新
	OnDelMailEvent = START_ECODE + 703, --删除回调
	OnDelALLMailEvent = START_ECODE + 704, --一键删除回调
}

EventCode.Equipment = {
	OnUpdatePageInfo = START_ECODE + 850, -- 更新装备分页信息
	OnEquipmentSelected = START_ECODE + 851, -- 选择装备
	OnMaterialSelected = START_ECODE + 852, -- 选择材料
	IsShowEquipment = START_ECODE + 853, -- 是否显示普装穿戴特效
	OnWearEquipment = START_ECODE + 854, --请求穿戴普装
	OnShowEquipment = START_ECODE + 855, --显示普装穿戴界面
	OnEquipRedDotPrompt = START_ECODE + 856, --背包入口红点提示
	OnEquipMaterialChange = START_ECODE + 857, --普装材料数量变化
	OnGemEquip = START_ECODE + 858, --镶嵌 替换宝石 升级宝石 事件通知
	OnOnShowBreakThroughEffect = START_ECODE + 859, --普装突破后普装界面显示特效
	OnAutoInlay = START_ECODE + 860, --自动镶嵌
	OnEngraveSuccess = START_ECODE + 861, --铭刻成功特效
	OnRecastBattleChange = START_ECODE + 862, --可重铸提示变化
	OnUpdataEquipPart = START_ECODE + 863, --普装部位更新
	OnUpdataEquipSuit = START_ECODE + 864, --普装套装更新
	OnUpdateRecommendDots = START_ECODE + 865, --普装推荐装备红点更新
	OnResolveEquipSelect = START_ECODE + 866, --普装分解选中状态变更
}
EventCode.Team = {
	OnAskCreateTeam = START_ECODE + 901, --请求创建队伍
	OnAskTeamNearby = START_ECODE + 902, --请求附近队伍列表
	OnAskApplyJoin 	= START_ECODE + 903, --请求申请加入队伍
	OnAskQuitTeam	= START_ECODE + 904, --请求离开队伍
	OnAskTransferLeader = START_ECODE + 905, --请求移交队长
	OnAskKickMember = START_ECODE + 906, --请求移除玩家
	OnAskInvite 	= START_ECODE + 907, --请求邀请玩家
	OnAskAgreeJoin	= START_ECODE + 908, --请求同意邀请入队的申请
	OnAskRefuseJoin = START_ECODE + 909, --请求拒绝邀请入队的申请
	OnAskApproveMember = START_ECODE + 910, --请求批准玩家入队申请
	OnAskOpposeMember = START_ECODE + 911, --请求拒绝玩家入队申请
	OnAskPlayerNearby = START_ECODE + 912, --请求附近玩家列表
	OnRemoveInviteList = START_ECODE + 913, --请求清空申请列表
	OnClearApplyList = START_ECODE + 914, --请求清空邀请列表
	OnAskTransferToMember = START_ECODE + 915, --请求传送前往队员身边
	OnAskApplyJoinPlayer = START_ECODE + 916, --请求加入玩家队伍
	OnAskChangeTarget = START_ECODE + 917, --请求改变队伍目标
	OnAskTargetTeamData = START_ECODE + 918, --请求目标队伍数据
	OnAskStarAutoMatch = START_ECODE + 919, --请求开始匹配
	OnAskStopAutoMatch = START_ECODE + 920, --请求取消匹配

	OnUpdateTeamEvent = START_ECODE + 921, --更新队伍成员信息	
	OnUpdateTeamInviteEvent = START_ECODE + 922, --更新邀请组队信息
	OnUpdateTeamApplyEvent = START_ECODE + 923, --更新申请入队信息
	OnUpdateTeamDestEvent = START_ECODE + 924, --更新队伍目标
	OnTeamMainRedDot	=	START_ECODE + 925, --更新申请/邀请红点提示
	OnTeamTeamNearby = START_ECODE + 926, --更新附近队伍
	OnTeamPlayerNearby = START_ECODE + 927, --更新附近玩家
	OnTeamActivityTarget = START_ECODE + 928, --更新目标队伍数据
	OnShowOperationByType = START_ECODE + 929, --根据操作类型显示队伍申请/邀请面板
	OnShowActivityByTarget = START_ECODE + 930, --显示指定目标的组队活动
	OnTeamAutoMatchChange = START_ECODE + 931, --自动匹配状态变更
	OnUpdateTeamAutoAgree = START_ECODE + 932, --更新自动同意按钮状态

	OnAskInviteList = START_ECODE + 933, --请求请求添加队员列表(好友或者帮派)
	OnUpdateAddPlayerList = START_ECODE + 934, --更新添加队员列表(好友或者帮派)
	OnAskCallFollow = START_ECODE + 935, --请求召集队员跟随

	OnLeaderChange = START_ECODE + 936, --队长变更
	OnShowFollowMsg = START_ECODE + 937, --跟战提示
	OnShowJoinTeamText = START_ECODE + 938, --入队飘字
	OnShowChangeDestText = START_ECODE + 939, --目标变更飘字
	OnTeamAddOrDel = START_ECODE + 940, --队伍人数增加或者减少

	OnAskTeamGang = START_ECODE + 941, --请求宗派队伍列表

	OnUpdateTeamTraceEffect = START_ECODE + 942, --更新任务队伍追踪栏特效
	OnAllTeamDataChange = START_ECODE + 943, --整队数据变更
	OnTeamReadyChange = START_ECODE + 944, --队伍准备数据更新
	OnShowTeamReadyWin = START_ECODE + 945, --显示队伍准备界面
	OnHideTeamReadyWin = START_ECODE + 946, --隐藏队伍准备界面
	OnCheckWildBossDest = START_ECODE + 947, --检查是否自动切换荒兽目标

	OnAskApplyLeader = START_ECODE + 948, --请求成为队长
	OnUpdateApplyLeaderFlag = START_ECODE + 949, --更新申请队长标识
	OnUpdateTraceToggle = START_ECODE + 950, --更新追踪栏收起按钮红点
	OnMatchTeamInterface = START_ECODE + 951, --切换到队伍面板
	OnLeaderInDungeon = START_ECODE + 952, --加入队伍时队长在副本中

	OnAskCreateMatchTeam = START_ECODE + 953, --请求创建匹配队伍
	OnLeaderTransferBack = START_ECODE + 954, --转移队长给指定副本次数最多的队员返回
	OnAskTransferDest = START_ECODE + 955, --请求自动化队长转让
	OnAskTeamDissolve = START_ECODE + 956, --请求自动化解散队伍
	
	OnTeamApplyListBtn = START_ECODE + 958,--主界面申请提示
	OnTeamInviteList = START_ECODE + 959,--主界面邀请按钮提示
	OnUpdateIsLeader = START_ECODE + 960,--主界面队伍标记
	OnTeamInviteListUpdate = START_ECODE + 961,--主界面邀请列表更新
	OnTeamDataInfoUpdate = START_ECODE + 962,--组队主界面更新
	OnTeamTargetUpdate = START_ECODE + 963,--跟新招募目标文字
	OnTeamCreate = START_ECODE + 964,--快捷组队界面创建队伍时
	OnTeamApplyListOpen = START_ECODE + 965,--快捷组队界面创建队伍时
	OnReqTeamReadyCallBack = START_ECODE + 966,--请求组队准备回调
	OnReqTeamReadyPanelShow = START_ECODE + 967,--组队准备界面显示
	OnReqTeamReadyBtnShow = START_ECODE + 968,--组队准备按钮
}

EventCode.ClickEntity = {
	OnClickHero = START_ECODE + 1000, --点击主角
	OnClickPlayer = START_ECODE + 1001, --点击玩家
	OnClickMonster = START_ECODE + 1002, --点击怪物
	OnClickDoodad = START_ECODE + 1003, --点击挂件
	OnClickLoot = START_ECODE + 1004, --点击掉落物
	OnClickNpc = START_ECODE + 1005, --点击npc
	OnClickPlant = START_ECODE + 1006, --点击采集物
}

EventCode.Auction = {
	OnAuctionGoods 			= START_ECODE + 1100, --跟新拍卖货物
	OnAuctionLog			= START_ECODE + 1101, --更新拍卖记录
	OnAuctionNewPrice		= START_ECODE + 1102, --请求最新价网络返回
	OnAuctionUpdataSingle	= START_ECODE + 1103, --更新单条数据
	OnAuctionDot 			= START_ECODE + 1104, 
	OnAuctionCleanDot 		= START_ECODE + 1105,
}

EventCode.Market = {
	OnMarketGoods 			= START_ECODE + 1201, --跟新摆摊货物
	OnMarketOnlyShow		= START_ECODE + 1202, --只显示有货
	OnMarketMyGoods 		= START_ECODE + 1203, --更新我的摆摊
	OnMarketHistoryPrice	= START_ECODE + 1204, --历史平均价
	OnMarketUnstackSucceed	= START_ECODE + 1205, --下架成功
	OnMarkerOverdue			= START_ECODE + 1206, --过期状态更新
	OnItemChange 			= START_ECODE + 1207, --物品变化
	OnAttentionChange 		= START_ECODE + 1208, --关注的珍品变化
	OnPublicChange 			= START_ECODE + 1209, --公示的珍品变化
	OnPetChange 			= START_ECODE + 1210, --宠物的珍品变化
	OnAttentionDotChange 	= START_ECODE + 1211, --关注珍品红点变化
	OnMyRarityChange 		= START_ECODE + 1212, --上架的珍品变化
	OnShowLowerPriceTips 	= START_ECODE + 1213, --打开最低价指定道具的购买tip
}

EventCode.Dungeon = {
	OnEnterDungeon			= START_ECODE + 1301,
	OnUpdateSeriesLC		= START_ECODE + 1302,
	OnAutoSeries 			= START_ECODE + 1303,--一条龙自动寻路
	OnUpdateSeriesLCell		= START_ECODE + 1304,--副本左侧信息栏 单个回调
	OnCheckAutoFight        = START_ECODE + 1305,--检测是否自动跟战
	OnShowMessage           = START_ECODE + 1306,--提示信息
	OnFirstFindScene        = START_ECODE + 1307,--第一次寻路
	OnReadyTimeOver			= START_ECODE + 1308,--准备时间结束
	OnSentStatistics		= START_ECODE + 1309,--副本统计结果
	OnWTEntranceInfo        = START_ECODE + 1310,
	OnKillAllBass			= START_ECODE + 1311,--boss全击败
	OnShowDungeonvictory	= START_ECODE + 1312,--单人副本挑战成功界面
	OnAutoStateChange		= START_ECODE + 1313,--副本自动化状态变化
	OnSeriesNpcRespond		= START_ECODE + 1314,--一条龙寻路npc坐标返回
	OnRefreshShowState		= START_ECODE + 1315,--副本自动化显示刷新
	OnAutoSwitchChange		= START_ECODE + 1316,--副本自动化开关
	OnCreateDungeonFailed	= START_ECODE + 1317,--副本创建成功
	OnCreateDungeonSuccess	= START_ECODE + 1318,--副本创建失败
}

EventCode.Gang = {
	OnGangBaseUpData			= START_ECODE + 1400,
	OnGangExtraDataUpData		= START_ECODE + 1401,
	OnGangMembersUpData			= START_ECODE + 1402,
	OnGangListUpData			= START_ECODE + 1403,
	OnGangApplysUpData			= START_ECODE + 1404,
	OnGangBuildingsUpData		= START_ECODE + 1405,
	OnGangContributionsUpData 	= START_ECODE + 1406,
	OnGangApplyRespon 			= START_ECODE + 1407,
	OnGangOpenBuild 			= START_ECODE + 1408,
	OnGangOpenPost 				= START_ECODE + 1409,
	OnGangHeroUpdate 			= START_ECODE + 1410,
	OnGangImpartList 			= START_ECODE + 1411,
	OnGangImpartReqList			= START_ECODE + 1412,
	OnGamgWarBidRequist			= START_ECODE + 1413,
	OnGangRedBagList			= START_ECODE + 1414,
	OnGangRedBagDetail			= START_ECODE + 1415,
	OnGrabRedenvBack			= START_ECODE + 1416,
	OnSendRedenv				= START_ECODE + 1417,
	OnGangAdChange				= START_ECODE + 1418,
	OnGangIdChange				= START_ECODE + 1419,
	OnGangMallUpdate			= START_ECODE + 1420,
	OnGangInvited				= START_ECODE + 1421,--宗派邀请
	OnGangNameChange			= START_ECODE + 1422,--改名
	OnGangRedDot				= START_ECODE + 1423,--通知主面板
	OnGangBeKnickOut			= START_ECODE + 1425,--被踢出宗派
	OnGangJoinSuccess			= START_ECODE + 1426,--成功加入宗派
	OnBuildUpdate				= START_ECODE + 1427,--升级回调
	OnGangRedBagDetailChain		= START_ECODE + 1431,--超链接查看信息
	OnGangApplyRedDot			= START_ECODE + 1432,--申请列表红点
	OnGangLeave					= START_ECODE + 1433,--离开宗派
	OnGangRemove				= START_ECODE + 1434,--宗派解散
	OnGangSync					= START_ECODE + 1435,--宗派第一次同步
	OnGangBuildRedDot			= START_ECODE + 1436,--建筑红点
	OnGangOpenRedenv 			= START_ECODE + 1437,--打开红包
	OnGangRedenvDetail          = START_ECODE + 1438,--打开红包详细
	OnGangClear		            = START_ECODE + 1439,--宗派清空事件
	OnGangRedenvDel		        = START_ECODE + 1440,--宗派红包删除事件
	OnGangContributionChang		= START_ECODE + 1441,--宗派帮贡变化
	OnGangMemberRemove			= START_ECODE + 1442,--成员离开/被踢
	OnGangSuffixsChange			= START_ECODE + 1443,--称谓批量修改
	OnGangFunUpdate				= START_ECODE + 1444,--宗派建设基金
	OnGangPostTypeChange		= START_ECODE + 1445,--宗派职位变化
	OnGangFilterImpart			= START_ECODE + 1446,--传功服务器筛选数据
	OnGangEliteNum				= START_ECODE + 1447,--宗派魔影数据
	OnGangAuctionDisCount		= START_ECODE + 1448,--宗派拍卖分配次数
	OnGangPostTypeFull			= START_ECODE + 1449,--宗派任命职位已满
	OnShowMergePanel			= START_ECODE + 1450,--显示族合并
	OnUpDataMergePanel			= START_ECODE + 1451,--更新列表
	OnOpenMergeOprationPanel	= START_ECODE + 1452,--打开操作列表
	OnUpOprationMergePanel		= START_ECODE + 1453,--刷新操作列表
	OnUpDataMergeMsg			= START_ECODE + 1454,--合并刷新数据（Test）
	OnUpDataMergeBtnRedDot		= START_ECODE + 1455,--刷新合并宗派按钮红点（Test）
	OnGangImpartPastDue			= START_ECODE + 1456,--刷新过期请求传功数据
	OnLevelRedBagData			= START_ECODE + 1457,--等级红包数据返回
	OnPostSetRedHot				= START_ECODE + 1458,--职位设置完
	OnUpdatePrivilege 			= START_ECODE + 1459,--宗派豪礼
	OnUpdatePrivilegeStats		= START_ECODE + 1460,--宗派豪礼领取
	OnGangPrivileges			= START_ECODE + 1461,--宗派特权数据
	OnGangWinUpdate				= START_ECODE + 1462,--宗派面板刷新通用
	OnEliteBossAllKill			= START_ECODE + 1463,--宗派侵袭Bosss全击败
	OnSendPasswordWidget        = START_ECODE + 1464,--向宗派密码界面传递信息
	OnSendGlodsIsNotEnough      = START_ECODE + 1464,--向绑银不足界面传递信息
	OnSendInputPasswordFunc     = START_ECODE + 1465,--密码输入后是禅让还是解散
	OnGangSalaryRedDot     		= START_ECODE + 1466,--薪酬红点
	OnGangChangePassword     	= START_ECODE + 1467,--修改密码成功关闭界面
	OnGangSkillPractice     	= START_ECODE + 1467,--修改密码成功关闭界面
	OnGangSelfLingShou     		= START_ECODE + 1468,--个人灵兽居数据更新
	OnGangOtherLingShou     	= START_ECODE + 1468,--宗派灵兽居数据更新
	
}

EventCode.Artifact = {
	--ask
	OnAskIdentifyArtifact = START_ECODE + 1500, --请求鉴定神器
	OnAskEquipArtifact = START_ECODE + 1501, --请求装备神器
	OnAskUnEquipArtifact = START_ECODE + 1502, --请求卸下神器
	OnAskStrengthenArtifact = START_ECODE + 1503, --请求强化神器
	OnAskBaptizeArtifact = START_ECODE + 1504, --请求洗练神器
	OnAskQuenchArtifact = START_ECODE + 1505, --请求淬炼神器
	OnAskReplaceEntry = START_ECODE + 1506, --请求替换神器词条
	OnAskForgeArtifact = START_ECODE + 1507, --请求打造神器
	OnAskDecomposeArtifact = START_ECODE + 1508, --请求分解神器
	--UIUpdate
	OnUpdateArtifactStar = START_ECODE + 1551, --更新神器星级
	OnShowBaptizeResult = START_ECODE + 1553, --显示洗练结果界面
	OnUpdateBaptizeSelect = START_ECODE + 1554, --更新洗练界面的复选框状态
	OnReplaceProtoBack = START_ECODE + 1555, --洗练替换协议返回
	OnForgeSuccess = START_ECODE + 1556, --打造成功
	OnArtifactIdentify = START_ECODE + 1557, --鉴定成功
	OnForgeRedDot = START_ECODE + 1558, --打造红点提示
	OnCoahuiliteChange = START_ECODE + 1559, --陨铁数量变化
	OnStrengthenMaterial = START_ECODE + 1560, --强化材料变化
	OnMainBagArtifact = START_ECODE + 1561, --背包中的核装变化
	OnArtifactForgeCheck = START_ECODE + 1562, --打造红点检查
	OnForgeLuckyChange = START_ECODE + 1563, --打造祝福值变化
}

EventCode.FamilyFrie = {
	OnFamilyFireDrink			= START_ECODE + 1601,  --喝酒返回
	UpdataFamliyFrieInfo        = START_ECODE + 1602,  --跟新家族烤火信息
	UpdataQuestionData          = START_ECODE + 1603,  --跟新题目信息
	UpdataRollDice              = START_ECODE + 1604,  --骰子返回
	UpdataQuestion              = START_ECODE + 1605,  --更新题目
	ShowFamilyFrie              = START_ECODE + 1606,  --打开家族烤火界面
	CloseFamilyFrie             = START_ECODE + 1607,  --隐藏家族烤火界面
	--UpdataQuestionTime          = START_ECODE + 1606,  --同步答题时间
}


EventCode.Realm = {
	OnUpStageValue              = START_ECODE + 1672,  --当前灵气可以升级
	OnUpdateSteadyTaskData        = START_ECODE + 1675,  --更新境界任务数据
	OnMainTopRight                = START_ECODE + 1677,  --右上角更新
	OnAttrUp	      	   = START_ECODE + 1679,  --属性飘字
	
	OnCloseRelamPanel          = START_ECODE + 1682,  --悟道时间事件
}
EventCode.General = {
	OnGeneralListUpdate			= START_ECODE + 1701,  --更新魔将列表
	OnGeneralDamagesUpdate      = START_ECODE + 1702,  --更新魔将伤害列表
	OnGeneralAllKilled      	= START_ECODE + 1703,  --当前进行中的魔星Boss全击败
	OnGeneralJustOpen  	    	= START_ECODE + 1704,  --魔星活动刚开
	OnGeneralLeftButtons		= START_ECODE + 1705,  --更新魔星左侧按钮可见性
	OnRefreshGeneralMarks		= START_ECODE + 1706,  --刷新魔星坐标标识
}

EventCode.Task = {
	OnTaskFiring				= START_ECODE + 1801, --显示放火扫地进度
	OnTaskComplete				= START_ECODE + 1802, --任务列表更新完成
	OnSyncAssistCount			= START_ECODE + 1803, --更新请求次数
	OnSyncHelpList				= START_ECODE + 1804, --更新求助列表
	OnAskForHelp				= START_ECODE + 1805, --更新求助次数
	OnShowTaskSubmit			= START_ECODE + 1806, --显示上交确认框
	OnShowSoliloquize			= START_ECODE + 1807, --显示主角自言自语界面
	OnCompleteTask				= START_ECODE + 1808, --提交任务
	OnTaskClicked				= START_ECODE + 1809, --任务被点击(任务面板 或者 任务追踪栏触发)
	--请求
	OnAskTaskArrivePos			= START_ECODE + 1851, --到达任务指定位置
	OnAskTaskRecycle			= START_ECODE + 1852, --任务回收物品
	OnAskTalkMyself				= START_ECODE + 1853, --自言自语,
	OnClickFailedTask           =START_ECODE + 1810,--点击失败任务

	--A by Wenmin.Yu, 2017-01-05
	--与任务相关单人模式实体的处理
	CiTangTask= START_ECODE + 1853,--尝试刺探
	OnPushCiTangOrangeLvl=START_ECODE + 1852,--刺探橙色情报推送

	OnClientNpcClicked			= START_ECODE + 1854, --进行中任务的npc被点击
	OnClientPlantCollected		= START_ECODE + 1855, --采集物被收集

	OnBreakPlantCollected		= START_ECODE + 1856, --停止采集

	OnClickTraceTask			= START_ECODE + 1857, --点击任务追踪栏的任务

	OnTaskPlantUpdate			= START_ECODE + 1858, --采集任务更新
	OnTaskFantasyCopyPlant		= START_ECODE + 1859, --幻境副本采集任务更新通知继续寻路采集
	OnRecycleByInstance		    = START_ECODE + 1860, --幻境副本回收物品成功返回
	AutoTaskPause				= START_ECODE + 1861, --自动任务暂停
	AutoTaskContinue			= START_ECODE + 1862, --自动任务继续
	OnShowDailyActivity         = START_ECODE + 1863, --任务跳转打开活动界面
	OnDownTask					= START_ECODE + 1864, --模拟点击自动任务
	OnTaskAcceptFailed			= START_ECODE + 1865, --接受任务失败
	OnTaskAcceptSuccess			= START_ECODE + 1866, --接受任务成功
	OnTaskGiveUp=START_ECODE + 1867,--放弃任务
}

EventCode.Skill = {
	OnUpgradeGest      			= START_ECODE + 1901, --功法升级回调  
	OnSkillChange				= START_ECODE + 1902, --技能更换回调
	OnSkillUpdate				= START_ECODE + 1903, --技能变化抛出
	OnSkillBlock				= START_ECODE + 1904, --技能按钮灰化
	OnSkillUnBlock				= START_ECODE + 1905, --技能按钮恢复
	OnSkillRedDot				= START_ECODE + 1906, --技能主面板红点
	OnSkillCheckRedDot			= START_ECODE + 1907, --技能面板检查红点
	OnSkillUnLock				= START_ECODE + 1908, --技能解锁
	OnSpecialUnLock				= START_ECODE + 1909, --技能引导模拟解锁
	OnHookBlock					= START_ECODE + 1910, --挂机屏蔽
	OnHookUnBlock				= START_ECODE + 1911, --挂机取消屏蔽
	OnShowSkillOpen				= START_ECODE + 1912, --显示技能开启界面
	OnSkillUIUpdate				= START_ECODE + 1913, --UI面板技能刷新
	OnSkillOpAniFinish			= START_ECODE + 1914, --UI动画播放完毕
	OnSlideBtnDown				= START_ECODE + 1915, --按下冲刺按钮
	OnSlideBtnUp				= START_ECODE + 1916, --释放冲刺按钮
	OnSlideBtnDowning			= START_ECODE + 1917, --长按冲刺按钮
	OnJoyStickMove				= START_ECODE + 1918, --键盘移动
}

EventCode.Activity = {
	OnActivityDataChange =   START_ECODE + 2001, --活动数据改变
	OnUpdateWildBossStatus = START_ECODE + 2002, --野外Boss状态变更
	OnActivityNewsChange =   START_ECODE + 2003, --消息提示改变
	OnActivityMapTime =      START_ECODE + 2004, --活动倒计时时间改变
	OnUpdatePanelData =      START_ECODE + 2005, --数据刷新活动界面
	OnRecActivityInfo =      START_ECODE + 2006, --接收活动界面数据
	OnGetReward 	  =      START_ECODE + 2007, --获取活跃奖励
	OnOperateBtn 	  =      START_ECODE + 2008, --前往按钮执行
	OnInitGoals		  =      START_ECODE + 2009, --前往按钮执行
	OnUpdateActivityJoinTime =      START_ECODE + 2010, --更新活动每日参加次数
	OnChangeActOpedCache = START_ECODE + 2011, --更新活动已开启过的缓存
	OnWildBossStatusChange = START_ECODE + 2012, --野外Boss活动状态变化
	OnActivityDuringClose = START_ECODE + 2013, --进行中的活动入口关闭
	OnKillAllWildBoss = 	START_ECODE + 2014, --所有野外Boss被击败
	OnGeneralStatusChange = START_ECODE + 2015, --魔将活动状态变化
	OnActivityOver = START_ECODE + 2016, --活动结束
	OnSpanWildBossStatusChange = START_ECODE + 2017, --跨服野外Boss活动状态变化
	OnUpdateSpanWildBossStatus = START_ECODE + 2018, --跨服野外Boss状态变更
	
	OnClearHasFind = START_ECODE +2019, --清除魔影骤降的标记
	OnBattleDragonChange = START_ECODE + 2020, --龙脉争夺战活动状态变化
	OnRefreshWildBossMarks = START_ECODE + 2021, --荒兽Boss坐标标识刷新
	OnInitnWildBossMarks = START_ECODE + 2022, --荒兽Boss坐标标识初始化

	OnAutoCacheClickAct = START_ECODE + 2023, --默认记录未点击的活动
	OnUpdateActivityMessage = START_ECODE + 2024, --更新活动信息

	OnWorldBossActEnd = START_ECODE + 2025, --混沌废墟活动结束

	OnUpdateRightTopEvent = START_ECODE + 2026, --通知主界面的按钮点击
	OnUpdateActivityNewOpen = START_ECODE + 2027, --活动刚开
	OnUpDataActivityInfo = START_ECODE + 2028, --活动数据改变 日常活动次数变化

}

EventCode.Title = {
	OnTitleChange              = START_ECODE + 2101,  -- 称号改变 通知场景层
	OnTitleUpdate              = START_ECODE + 2102,  -- 称号刷新 
	OnTitleRedDot              = START_ECODE + 2103,  -- 称号红点 
}

EventCode.Honour = {
	OnUpgrade                  = START_ECODE + 2201,  -- 头衔升级回调
	OnHonourRedDot             = START_ECODE + 2202,  -- 头衔红点
	OnOpenHonuerPanel		   = START_ECODE + 2203,  -- 打开头衔界面
}

EventCode.Precious = {
	-- OnReFreshData				 =	START_ECODE + 2302,--法宝刷新数据
	OnRefreshItem				 =	START_ECODE + 2303,--抽奖法宝刷新item数据
	-- OpenMsgView			 		 =	START_ECODE + 2304,--打开信息界面
	-- OpenStrengthView			 =	START_ECODE + 2305,--打开强化界面
	-- OpenStarView			 	 =	START_ECODE + 2306,--打开升星界面
	-- OnReFreshMsgview			 =	START_ECODE + 2307,--刷新信息界面


	-- OnReFreshStarLvup			 =	START_ECODE + 2309,--刷新升星界面
	-- OpenChangeMaterialView		 =	START_ECODE + 2310,--打开兑换
	-- OnRefreshCfg 				 =	START_ECODE + 2311,--刷新数据排序
	OnRedPoinState				 =  START_ECODE + 2312,--刷新红点
	OnFreeTime                   =  START_ECODE + 2313,-- 免费倒计时
	CheckPrecious				 =  START_ECODE + 2314,--查看法宝信息
	CheckRedDot 				 =  START_ECODE + 2315,--红点变化
	--新的msg事件 -- start
	OnChipUpdate				 =  START_ECODE + 2301, --法宝碎片更新--处理红点显示
	OnAddNew					 =  START_ECODE + 2302, --法宝增加
	OnMsgRedDot					 =  START_ECODE + 2304, --法宝信息界面红点刷新
	OnResonance					 =  START_ECODE + 2305, --法宝共鸣封印
	OnClickTipBg				 =  START_ECODE + 2306, --法宝封印提示
	OnRefreshEquip				 =  START_ECODE + 2316,--刷新装备
	OnRefreshItemOwn			 =  START_ECODE + 2317,--刷新拥有的法宝界面
	OnRefreshNotItemOwn			 =  START_ECODE + 2318,--刷新未拥有的法宝界面
	OnMaterialChange             =  START_ECODE + 2318,--法宝材料变化
	--穿戴脱下法宝变更
	OnWearState                  =  START_ECODE + 2319,--穿戴发生变化
	OnChipChange 				 = 	START_ECODE + 2320, --法宝碎片变化--界面刷新
	OnPreciousChange 			 = 	START_ECODE + 2321, --法宝变化--共鸣封印 刷新法宝状态
	OnActionDebris				 = 	START_ECODE + 2322, --法宝抽奖翻牌动画
	OnChackGain					 = 	START_ECODE + 2323, --法宝是否可合成和共鸣--快捷合成共鸣
	-- OnReFreshStrengthen			 =	START_ECODE + 2308,--刷新强化界面
	--新的msg事件 -- end

}
EventCode.GangWar = {
	OnRefershGangWarApply 		 = START_ECODE + 2350,--申请参与参与城战
	OnRefershGangWarRoll		 = START_ECODE + 2351,--申请掷骰子
	OnGangWaringInfo             = START_ECODE + 2352,--战场信息
	OnGangWarArsenalInfo		 = START_ECODE + 2353,--器械库信息
	OnGangWarBroadcast			 = START_ECODE + 2354,--攻城战信息播报
	OnGangWarBroadcastEnd		 = START_ECODE + 2355,--攻城战信息播报结束
	OnTrySceneLoad				 = START_ECODE + 2356,--攻城战进入流程
	OnGangNavigationInfo     	 = START_ECODE + 2357,--城战导航栏信息更新
	OnClickPlantCallBack      	 = START_ECODE + 2358,--请求占旗回调
}

EventCode.Bloodline = {
	OnUpdataBloodlineData 		= START_ECODE + 2401,
	OnUpdataBloodlineLvData		= START_ECODE + 2402,
	OnUpdataAcupointData		= START_ECODE + 2403,
	OnPacticeDot				= START_ECODE + 2403,
	OnAcuptionDot				= START_ECODE + 2404,
	OnAcuptionSucceed			= START_ECODE + 2405,
	OnChangeAttr				= START_ECODE + 2406,
	OnItemChange				= START_ECODE + 2407,
}

EventCode.WorldBoss = {
	OnUpdataBossLog 		= START_ECODE + 2501,
	OnUpdataLootLog 		= START_ECODE + 2502,
	OnUpdataMyLog			= START_ECODE + 2503,
	OnUpdataRnkData			= START_ECODE + 2504,	
	OnUpdataLootList		= START_ECODE + 2505,
	OnUpdataPlayerSituation = START_ECODE + 2506,
	OnUpdataBossLastTime 	= START_ECODE + 2507,
	OnUpdataLootLastTime	= START_ECODE + 2508,
	OnAddLoot				= START_ECODE + 2509,
}

EventCode.MainWin = {
	-- OnMainChageMode			= START_ECODE + 2601,
	OnUpdateTimeDown		= START_ECODE + 2602,
	OnChangeSAB				= START_ECODE + 2603,
	OnSACType				= START_ECODE + 2604,
	OnShowSkill				= START_ECODE + 2605,
	OnChangeTCDesc			= START_ECODE + 2606,
	OnHideQuickBtn			= START_ECODE + 2607,
	OnExpandChat			= START_ECODE + 2708,
	OnLSGather				= START_ECODE + 2709,
	OnCancelLSGather 		= START_ECODE + 2710,
	OnHideLeave				= START_ECODE + 2711,
	OnShowLeave				= START_ECODE + 2712,
	OnTimeDownEnd 			= START_ECODE + 2713,
	OnTeamBtnClick	 		= START_ECODE + 2714,
	OnChangeCollect			= START_ECODE + 2715,
	OnHideTCDesc			= START_ECODE + 2716,
	OnRestoreSAB			= START_ECODE + 2717,
	OnShowAlpha				= START_ECODE + 2718,
	OnShowMainUIWidget		= START_ECODE + 2719,
	OnHideMainUIWidget		= START_ECODE + 2720,
	OnColorChatShow			= START_ECODE + 2721,
	OnShowDownloadWidget	= START_ECODE +	2722,
	OnShowLeaveBtn	        = START_ECODE +	2723,
	OnShowTaskDailyEffect	= START_ECODE +	2724,
	OnRightBtnClick			= START_ECODE +	2725,
	OnPopupViewUpdate		= START_ECODE +	2726,
	OnShowLeaveFightTime	= START_ECODE + 2727,
	OnShownewfuncWidget		= START_ECODE + 2728,
	OnHidenewfuncWidget		= START_ECODE + 2729,
	OnUpdateFastBattle		= START_ECODE + 2730,
	PushWheelSurf=START_ECODE + 2731,
}

EventCode.Battlefield = {
	OnUpdateRankList = START_ECODE + 2702, --更新战场排行榜
	OnShowRankResult = START_ECODE + 2703, --显示战场结果界面

	--协议
	OnAskRankList = START_ECODE + 2751, --请求战场排行榜数据
	OnStopScene	  = START_ECODE + 2752, --单机 停止战斗
	OnTribalArenaGemState = START_ECODE + 2755,  --更新宗派争霸宝珠状态
}

EventCode.Mount = {
	OnFirstOpenMount = START_ECODE + 2801, --第一次打开坐骑
	OnRideMount	= START_ECODE + 2803, --上坐骑
	OnOffMount	= START_ECODE + 2803, --下坐骑
	OnRideChange = START_ECODE + 2804, --骑乘状态变化
	OnMountCardChange = START_ECODE + 2805, --坐骑激活道具变化
	OnMountSkinChange = START_ECODE + 2806, --坐骑皮肤道具改变
	OnUpdateMountUpChange   = START_ECODE + 2814,--坐骑升阶道具改变
	OnUpdateVigorMountChange   = START_ECODE + 2814,--坐骑升阶道具改变
	OnUpdateMountArtifactEvent = START_ECODE + 2815,	--刷新坐骑神器
	OnMountactPutOnEffect = START_ECODE + 2816 --核装穿上特效
}

--时装
EventCode.Fashion = {
	OnUpdateFashion = START_ECODE + 2901, --刷新时装
	OnOpenFashion = START_ECODE + 2902, --打开对应阶的时装页面
	OnFashionCollection = START_ECODE + 2903, --时装收藏成功
}

EventCode.Pet = {
	OnPetUpdate = START_ECODE + 2905,
	OnPetBloodUpdate = START_ECODE + 2906,
	OnPetSync = START_ECODE + 2907, --宠物数据初始化
	OnPetBookCallback = START_ECODE + 2908,
	OnPetChangeStatus = START_ECODE + 2909,
	OnPetChangeScene = START_ECODE + 2910,--切换场景时通知
	OnPetAnneal = START_ECODE + 2911,--洗练回调
	OnPetAddOrDel = START_ECODE + 2912,--宠物增加或者删除
	OnPetCurId = START_ECODE + 2913,--登录时传递宠物数据
	OnPetActivation = START_ECODE + 2914,--宠物皮肤激活/升级
	OnUsePetSkin = START_ECODE + 2915,--使用宠物皮肤
	OnSupport  = START_ECODE +2920,   --助战状态
	OnMergeNew = START_ECODE + 2921,--合体
	OnSexGetItem = START_ECODE + 2922, --交配完成取回蛋
	OnUpdateSmeltVal = START_ECODE + 2923,
}

--时装
EventCode.FantasyCopy = {
	OnFantasyCopy = START_ECODE + 3001, --幻境副本
}

--门派竞技
EventCode.SectBattle = {
	OnPushRank 			= START_ECODE + 3101,
	OnUpdateRank 		= START_ECODE + 3102,
	OnPushWatchData 	= START_ECODE + 3103,
	OnExitWatch 		= START_ECODE + 3104,
	OnEnterWatch 		= START_ECODE + 3105,
	OnPushSupport 		= START_ECODE + 3106,
	OnPushArenaBattle 	= START_ECODE + 3107,
	OnPushBattleResult 	= START_ECODE + 3108,
	OnPushProCurStatus 	= START_ECODE + 3109,
	OnShowCDAni 		= START_ECODE + 3110,
	OnPushEnterWatchArea = START_ECODE + 3111,
}

--排行榜
EventCode.Ranking = {
	OnRecRankingData = START_ECODE + 3201,
	OnJumpRanking = START_ECODE + 3202,
}

EventCode.Info = {
	OnRoleInfo = START_ECODE + 3301,
	OnMountInfo = START_ECODE + 3302,
	OnPetInfo = START_ECODE + 3303,
	OnPreciousInfo = START_ECODE + 3304,
	OnUpdateData = START_ECODE + 3305,
	OnAddLabels = START_ECODE + 3306,
	OnRemoveLabels = START_ECODE + 3307,
	OnUpDataLabels = START_ECODE + 3308,
	OnLabelsTextChange = START_ECODE + 3309,
	OnPDecTextChange = START_ECODE + 3310,
	OnVerificationInfo = START_ECODE + 3311,
	ShowVerfication = START_ECODE + 3312,
	VerficationLike = START_ECODE + 3313,
	RankFirstModelRT = START_ECODE + 3314,
	OffLineTags = START_ECODE + 3315,
}

--角色信息	
EventCode.RoleInfo = {
	OnRename = START_ECODE + 3401,
	OnUpdateAvatarId = START_ECODE + 3402,
	OnUpdatePersonalJob = START_ECODE + 3403,
	OnUpdateSafetyLock = START_ECODE + 3404,
	ShowSiteInterface = START_ECODE + 3405,
}

--剧情
EventCode.Story = {
	OnPlayStory = START_ECODE + 3501, --播放剧情
	OnStopStory = START_ECODE + 3502, --停止剧情
	OnPauseStory = START_ECODE + 3503, --暂停剧情
	OnContinueStory = START_ECODE + 3504, --恢复剧情
	OnShowDialoguePanel = START_ECODE + 3505, --显示对白界面
	OnShowOpenPanel = START_ECODE + 3506, --显示开启表现界面
	OnShowBarrage = START_ECODE + 3507, --显示弹幕
	OnShowMiniStory = START_ECODE + 3508, --显示主界面上的剧情对话
	OnHideStoryWidget = START_ECODE + 3509, --隐藏剧情界面(对白和开启表现)
	OnStoryOpenAction = START_ECODE + 3510, --播放剧情开启动画(界面)
	OnStoryOpenComplete = START_ECODE + 3511, --播放剧情开启动画(界面)完成
	OnCreateStoryEntity = START_ECODE + 3512, --创建剧情实体
	OnShowColorMask = START_ECODE + 3513, --颜色渐变遮罩
	OnStoryPlayComplete = START_ECODE + 3514, --剧情播放完毕通知
	OnAddStoryEffect = START_ECODE + 3515, --剧情界面特效
	OnMarryStoryText = START_ECODE + 3516, --剧情结婚对象文字
}

--生活技能
EventCode.LifeSkill = {
	OnUpdateVitality = START_ECODE + 3601, --更新活力值
	OnUpdateLifeSkillLv = START_ECODE + 3602, --更新生活技能
	OnChangeMake = START_ECODE + 3603, --跟新当前是否在制造物品
	OnUpdateRedDot = START_ECODE + 3604, --更新活力红点
	OnUpdateLifeSkillDot = START_ECODE + 3605, ----添加红点
	OnItemChange = START_ECODE + 3606,--物品变化
}

--爬塔
EventCode.ClimeTower = {
	OnUpdateMyScore = START_ECODE + 3651, --更新我的分数
	OnUpdateResetCount = START_ECODE + 3652, --更新重置次数
	OnUpdateCopy = START_ECODE + 3653, --更新关卡状态
	OnUpdateReward = START_ECODE + 3654, --更新积分领奖
	OnSendInvite = START_ECODE + 3655,--邀请玩家
	OnSucceedInvite = START_ECODE + 3656, --是否成功邀请玩家
	OnCancelSelect = START_ECODE + 3657, --取消选中
}
--大荒榜 
EventCode.Wildrank = {
	OnPlayerDataUpdate = START_ECODE + 3701,
	OnPlayerRankDataUpdate = START_ECODE + 3702,
	OnGroupRankDataUpdate 	= START_ECODE + 3703,
	OnDamageRecord = START_ECODE + 3704,
	OnGetReward = START_ECODE + 3705,
	OnPushChallengeList = START_ECODE + 3706,
	OnPushRefreshPlayerData = START_ECODE + 3707,
	OnIsAgent = START_ECODE + 3708,
}
--通天塔
EventCode.Babel = {
	PushReady = START_ECODE + 3751,--推送准备数据
	PushFight = START_ECODE + 3752,--推送战斗数据
	PushTowerFightSettle = START_ECODE + 3753,--推送战斗数据-结算阶段
	PushTowerFightSettleFnish = START_ECODE + 3754,--推送战斗数据-结算
	PushTowerFightSettleStart = START_ECODE + 3755,--推送战斗数据--开始战斗前数据
	OnTrySceneLoad = START_ECODE + 3756,--推送切图
	OnHidePhaseWidget = START_ECODE + 3757,--关闭
	OnCloseAll = START_ECODE + 3758,--关闭
}

--宗派试炼
EventCode.GangHunt = {
	OnUpdateState = START_ECODE + 3801,
	OnExitBtnState = START_ECODE + 3802,
}

EventCode.Login = {
	OnSelectServer = START_ECODE + 3851,
	OnRegisterResponse =  START_ECODE + 3852,
	OnChangePWDResponse =  START_ECODE + 3853,
	OnConnectInfo =  START_ECODE + 3854,
	OnLoginCode =  START_ECODE + 3855,
}

--成就
EventCode.Achievement = {
	OnUpdateAchievement = START_ECODE + 3901,
	OnOpenAchievement = START_ECODE + 3902,
	OpenAchievementTips = START_ECODE + 3903,
}

--帮助
EventCode.Help = {
	OpenHelpWidger = START_ECODE + 3951,
}

--福利
EventCode.Welfare = {
	UpdateWelfareReward = START_ECODE + 3981,
	UpdateWelfareOffine = START_ECODE + 3982,
	UpdateWelfareSign = START_ECODE + 3983,
	UpdateWelfareSilver = START_ECODE + 3984,
	SendRedStatus = START_ECODE + 3986,
	UpdateWelfareRedDot = START_ECODE + 3987,
	MonthlyCard = START_ECODE + 3988,
	DailyGift = START_ECODE + 3989,
	OnUpdateLvPcData = START_ECODE + 3985,
	GrowUp = START_ECODE + 3990,
	OnUpdateOperAct = START_ECODE + 3960,
	OnUpdateOperActRed = START_ECODE + 3961,
	OnUpdateDouChangeRed = START_ECODE + 3962,
	UpdataSaleRed = START_ECODE + 3963,
	UpdateCRecharge = START_ECODE + 3964,     --累计充值
	UpdataDaySumRed = START_ECODE + 3965,
	--UpdataCLoginRed = START_ECODE + 3967,
	UpdateWCLoginData = START_ECODE + 3968,   --累计登录
	OnUpdateTimeLimit = START_ECODE + 3969,
	OnUpdateFirstreCharge = START_ECODE + 3970,
	UpdataIntegralMall = START_ECODE + 3971,
	OnNoticeLottery = START_ECODE + 3972,
	OnLotteryList = START_ECODE + 3973,
	OnUpdateConversion = START_ECODE + 3974,

	OnUpdateConversionRedDot = START_ECODE + 3975,
	OnConversionRedDot = START_ECODE + 3976,
	OnNoticeFortuneCarLottery = START_ECODE + 3977,
	OnUpdateFortuneCarList = START_ECODE + 3978,
	OnUpdateDailyCharge = START_ECODE + 3979,
	OnUpdateBSData = START_ECODE + 3980,

	OnUpdateWMData = START_ECODE + 3981,
	OnUpdateSevenBData = START_ECODE + 3982,
	OnUpdateDGData = START_ECODE + 3983,
	OnUpdateGUPData = START_ECODE + 3984,
	OnUpdateWeekSale = START_ECODE + 3985,
	OnUpdateRedDotMain = START_ECODE + 3986,
	OnUpdateMonsterCarnival = START_ECODE + 3987,  --怪物嘉年华
	OnUpdateBossCarnival = START_ECODE + 3988,  --Boss嘉年华
}

--挂机
EventCode.Hook = {
    DestroyHook = START_ECODE + 3994,
	UpdateHook = START_ECODE + 3995,
}
--单人副本
EventCode.SingleDungeon = {
	OnResult = START_ECODE + 3996,
	RestState = START_ECODE + 3997,
	-- OnEndTime = START_ECODE + 3998,
} 

--A by Wenmin.Yu, 2016-11-23
--窗口事件
--使用稍大一些的号段，以分隔开功能事件
EventCode.Window = {
	OnShowMainWindow = START_ECODE + 4001, --显示主界面
	OnIsShowMain = START_ECODE + 4002, --是否显示主界面
	OnWindowShowed = START_ECODE + 4003, --显示界面
	OnWindowHided = START_ECODE + 4004, --隐藏界面(包括销毁)
}

--M by lijian,2016-12-5
-- lua层push msg处理,占用5001-6000
EventCode.Push = {
	OnPushDungeonStar		= START_ECODE + 5001,
	--OnPushDungeonStatus		= START_ECODE + 5002,
	OnPushItemSync			= START_ECODE + 5003,

	OnPushMailSync			= START_ECODE + 5004,
	OnPushChatData			= START_ECODE + 5005,
	OnPushFreeWorldChat		= START_ECODE + 5006,
	--OnPushSceneRecord		= START_ECODE + 5007,
	--OnPushChapterRecord	= START_ECODE + 5008,
	OnPushMallDataSync 		= START_ECODE + 5009,

	OnPushTeamDataSync	 	= START_ECODE + 5010,
	OnPushTeamInviteSync	= START_ECODE + 5011,
	--邀请他人，给队伍成员发送提示
	OnPushTeamInviteToMember = START_ECODE + 5012,
	OnPushErrorCode			= START_ECODE + 5013,
	OnPushColorChatCount	= START_ECODE + 5014,
	OnPushFriendList		= START_ECODE + 5016,
	OnPushFriendInvite	    = START_ECODE + 5017,
	OnPushEnemyList 		= START_ECODE + 5019,
	OnPushRevengeData 		= START_ECODE + 5020,
	OnPushAuctionItem		= START_ECODE + 5021,
	OnPushAuctionPriceChange = START_ECODE + 5022,
	OnPushPracticeTime		= START_ECODE + 5023,
	OnPushPracticeItem		= START_ECODE + 5024,
	OnPushAllMarketData		= START_ECODE + 5025,
	OnPushPlayerMarket   	= START_ECODE + 5026,
	OnPushServerLvl 		= START_ECODE + 5027,
	OnPushTeamSingleDataSync= START_ECODE + 5028,
	OnPushTeamApplyDataSync = START_ECODE + 5029,
	OnPushGangBase			= START_ECODE + 5030,
	OnPushGangExtraData		= START_ECODE + 5031,
	OnPushGangMembers		= START_ECODE + 5032,
	OnPushGangList			= START_ECODE + 5033,
	OnPushGangApplys		= START_ECODE + 5034,
	OnPushGangBuildings		= START_ECODE + 5035,
	OnPushGangContributions = START_ECODE + 5036,
	OnPushDungeonResult     = START_ECODE + 5037,
	OnPushLeaveDungeon		= START_ECODE + 5038,
	OnPushGangCampfireData  = START_ECODE + 5039,
	OnPushQuestionData      = START_ECODE + 5040,
	OnPushGeneralList		= START_ECODE + 5041,
	OnPushGeneralDamages	= START_ECODE + 5042,
	OnPushAnswerQuestionTime= START_ECODE + 5043,
	OnPushActivityStateList = START_ECODE + 5044,
	OnPushActivityState 	= START_ECODE + 5045,
	--OnLootInfo			 	= START_ECODE + 5046,
	OnPushTaskList			= START_ECODE + 5047,

	OnPushNewGest			= START_ECODE + 5048,
	OnPushArtifactStar		= START_ECODE + 5049,
	OnPushTitleList			= START_ECODE + 5050, --称号列表
	OnPushDrawRewardInfo	= START_ECODE + 5051,
	OnPushBloodlineData 	= START_ECODE + 5052,
	OnPushAcupointData		= START_ECODE + 5053,
    OnPushStopImpart		= START_ECODE + 5053,
	OnPushImpartInfo		= START_ECODE + 5054,
	OnPushImpartReqList		= START_ECODE + 5055,
	--OnPushImpartPlayerInfos	= START_ECODE + 5056,
	OnPushImpartConfirmInfo = START_ECODE + 5057,
	OnPushTaskHelpList		= START_ECODE + 5058,
	OnPushAssistCount		= START_ECODE + 5059,
	OnPushEntityBeKilled	= START_ECODE + 5060,

	OnPushGangPlayerInfo	= START_ECODE + 5061,
	OnPushWildBossData		= START_ECODE + 5062,
	OnPushMaxBidingChange   = START_ECODE + 5063,
	OnPushGangWarResult  	= START_ECODE + 5064,
	OnPushSceneTotemStaus	= START_ECODE + 5065,

	OnPushServerDay			= START_ECODE + 5066,
	OnPushRedenvUpdate		= START_ECODE + 5067,
	OnPushEntityConKill		= START_ECODE + 5068,

	--世界boss 
	OnPushWorldbossLog 		= START_ECODE + 5069,
	OnPushPersonLog			= START_ECODE + 5070,
	OnPushBossLastTime 		= START_ECODE + 5071,	
	OnPushPersonInfo		= START_ECODE + 5072,

	OnPushSceneProgress		= START_ECODE + 5073, -- 一条龙副本进度更新
	OnPushSceneWord			= START_ECODE + 5074, -- 副本内喊话 飘字
	
	--炎黄战场
	OnPushArenaEnterNum		= START_ECODE + 5076,
	OnPushArenaData			= START_ECODE + 5077,
	OnPushArenaResult		= START_ECODE + 5078,
	OnPushArenaKill			= START_ECODE + 5079,
	OnPushArenaCampScore	= START_ECODE + 5080,

	OnPushSceneInfo			= START_ECODE + 5081,
	OnPushLootTime			= START_ECODE + 5082,
	OnPushActMapTime		= START_ECODE + 5083,

	OnPushPetData 			= START_ECODE + 5084,
	OnPushActivityValues	= START_ECODE + 5085,
	ResetLivenessInfo 		= START_ECODE + 5086,
	PushDailyAct			= START_ECODE + 5087,
	OnPushMountsInfo		= START_ECODE + 5088,
	OnPushDoubleCharge		= START_ECODE + 5089,
	OnPushVipGiftData		= START_ECODE + 5090,
	OnPushSyncFashionData   = START_ECODE + 5091,
	OnPushSyncEquipFashion  = START_ECODE + 5092,

	--门派竞技
	OnPushProCurStatus		= START_ECODE + 5093,
	OnPushProBattleInfo		= START_ECODE + 5094,
	OnPushTransmit			= START_ECODE + 5095,
	OnPushRingResult		= START_ECODE + 5096,
	OnPushRingSupport		= START_ECODE + 5097,
	OnPushRingInfo			= START_ECODE + 5098,
	OnPushRingWatch			= START_ECODE + 5099,
	OnPushPlayerRingStatus	= START_ECODE + 5100,
	--角色信息
	OnPushChangeNameCount  	= START_ECODE + 5101,
	OnPushSercurityLockData	= START_ECODE + 5102,
	OnPushBeHelpList		= START_ECODE + 5105,
	OnPushLifeSkills		= START_ECODE + 5106,
	--宗派试炼状态
	OnPushTrainStatus		= START_ECODE + 5107,
	--大荒榜
	OnPushWildrankTime		= START_ECODE + 5108,

    --成就数据
    OnPushAchievement       = START_ECODE + 5109,
    --大荒榜 结算 降组
	OnPushDamageRecord		= START_ECODE + 5110,
	OnPushChallengeList 	= START_ECODE + 5111,
	OnPushDungeonStart		= START_ECODE + 5112,
	OnPushClimbTowerData 	= START_ECODE + 5113,

	--福利(奖励回收)
	OnPushRewardFind	    = START_ECODE + 5114,
	OnPushOfflineExpData    = START_ECODE + 5115,
	--藏宝图邀请
	OnPushTreasureInvite 	= START_ECODE + 5116,
	--通天塔
	OnPushTowerReadyData 	= START_ECODE + 5117,
	OnPushTowerScoreData 	= START_ECODE + 5118,
	OnPushTowerStateData	= START_ECODE + 5119,
	OnPushTowerfightSettle 	= START_ECODE + 5120,
	--藏宝图状态
	OnPushTreasueState		= START_ECODE + 5121,
	-- 推送广播公告
	OnPushBroadcast 		= START_ECODE + 5122,

	--好友缘分推荐
	OnPushFriendLuck		= START_ECODE + 5123,
	
	OnPushItemUseInfo		= START_ECODE + 5124,

	--剧情对话
	OnPushStoryDialogue		= START_ECODE + 5125,
	--队友喝酒消息
	OnPushUseWineItem 		= START_ECODE + 5126,
	--每日活动次数
	OnPushActivityJoin 		= START_ECODE + 5127,
	--推送骰子结果
	OnPushDiceResult 		= START_ECODE + 5128,

	--推送宗派商城列表
	OnPushGangMallData		= START_ECODE + 5129,
	--推送宗派邀请
	OnPushGangInvite		= START_ECODE + 5130,

	--发布通缉推送
	OnPushOpenWanted		= START_ECODE + 5131,
	--通缉列表推送
	OnPushWantedList		= START_ECODE + 5132,
	--当前通缉信息
	OnPushWantedState		= START_ECODE + 5133,
	--副本结束
	OnPushDungeonReadyOver  = START_ECODE + 5134,
	--福利签到
	OnPushSignInData    	= START_ECODE + 5135,
	--福利聚宝盆
	OnPushFreeCorncupia 	= START_ECODE + 5136,

	--红点推送
	OnPushRedNotice			= START_ECODE + 5137,
	--藏宝图
	PushTreasureCollect		= START_ECODE + 5138,
	--修炼丹BUFF
	OnPushPracticeExp		= START_ECODE + 5139,
	
	--新手引导数据
	OnPushNewGuideData		= START_ECODE + 5140,
	--登陆推送奖励信息
	OnPushWildrankReward    = START_ECODE + 5141,
	--挑战世界boss开始
	OnPushBossChallengeStart = START_ECODE + 5142,

	--附魔
	OnPushEnchantData 		= START_ECODE + 5143,
	--物品掉落
	OnPushRewardDraw  		= START_ECODE + 5144,
	-- 推送世界boss强制结算
	OnPushWorldBossActEnd   = START_ECODE + 5145,
	-- 推送传功数据
	OnPushImpartData   		= START_ECODE + 5146,
	--推送经验增加飘字
	OnPushExpAdd			= START_ECODE + 5147,
	--推送召集跟随
	OnPushTeamCallTogether	= START_ECODE + 5148,
	--运营活动推送
	OnUpdateActivityInfo    = START_ECODE + 5149,
	OnUpdateAddActivity     = START_ECODE + 5150,
	OnUpdateActivityStatus  = START_ECODE + 5151,
	OnPushGangAllData       = START_ECODE + 5152,
	--赠送物品日结
	OnPushDonateCount		= START_ECODE + 5153,
	OnPushRingStatus		= START_ECODE + 5154,

	OnPushTeamFollowPos		= START_ECODE + 5155,
	--大荒榜VIP次数重置
	PushWildrankVipCount	= START_ECODE + 5156,
	--大荒守榜人
	OnPushWildrankMonster	= START_ECODE + 5157,
	OnPushAuctionStatus		= START_ECODE + 5158,

	OnPushGmAnswerPlayer 	= START_ECODE + 5159,

	OnPushTransformCount    = START_ECODE + 5160,
	--追击荒兽提示信息
	OnPushChaseWildboss		= START_ECODE + 5161,
	--协助成功返回答题角色
	OnPushImperialQuestion  = START_ECODE + 5162,

	--珍品摆摊
	OnUpdatePlayerTreasureMarket = START_ECODE + 5163,
	OnUpdateTreasureMarket 		 = START_ECODE + 5164,
	OnUpdateAttentionTreasure 	 = START_ECODE + 5165,


	--宗派魔影
	OnPushGangEliteNums = START_ECODE + 5167,

	--拍卖分配
	OnPushAuctionDisInfo 		= START_ECODE + 5168,
	OnPushAuctionReady 			= START_ECODE + 5169,
	OnPushAliveCheck 			= START_ECODE + 5170,

	--当前进行中的魔将全击败
	OnPushGeneralKillAll		= START_ECODE + 5171,
	--当前宗派联盟状态
	OnPushGeneralUnionStatus	= START_ECODE + 5172,
	--已击败第一层boss
	OnPushKillGeneralFirstBoss	= START_ECODE + 5173,
	--下一层是否已开启
	OnPushNextFloorIsOpen		= START_ECODE + 5174,

	--队伍队长发呆信息
	OnPushTeamLeaderState		= START_ECODE + 5175,
	--替换队长弹窗
	OnPushReplaceMember			= START_ECODE + 5176,

	--跨服荒兽数据
	OnPushCrossWildBossData		= START_ECODE + 5177,

	--性别验证 点赞
	OnPushGenderTagState		= START_ECODE + 5178,

	--跨服战场
	OnPushBattleBoxData			= START_ECODE + 5179,
	OnPushBattleFieldData		= START_ECODE + 5180,
	OnPushCaveKeyNum			= START_ECODE + 5181,

	--聊天框更新状态
	OnPushChatBubbles    		= START_ECODE + 5182,
    
    --宗派特权
	OnPushGangPrivileges        = START_ECODE + 5183,
	--共舞 进出区域
	OnPushDanceAreaInOut		= START_ECODE + 5184,
	--共舞 跳舞信息
	OnPushDanceInfo				= START_ECODE + 5185,

	OnPushGeneralPosInfo		= START_ECODE + 5186,
	--侵袭boss数据
	OnPushEliteBossState		= START_ECODE + 5187,
	--地洞状态和坐标
	OnPushBattleCaveStatus		= START_ECODE + 5188,
	--战场BOSS状态和坐标
	OnPushBattleBossStatus		= START_ECODE + 5189,
	--翅膀推送
	OnPushWingData				= START_ECODE + 5190,
	--异族推送
	OnPushRaceInvadeNpcInfo 	= START_ECODE + 5191,
	OnPushRaceInvadeFirstEnter  = START_ECODE + 5192,
	--修炼丹推送
	OnPushPracticeData			= START_ECODE + 5193,
	--一键推送
	OnPushOneKeyInfo 			= START_ECODE + 5194,
	--推送求婚数据
	OnPushProposeInfo 			= START_ECODE + 5195,
	--推送求婚结果
	OnPushProposeResult			= START_ECODE + 5196,
	--推送结婚祝福
	OnPushBlessInfo				= START_ECODE + 5197,
	--荒兽巢穴
	OnPushSceneNestInfo         = START_ECODE + 5198, --荒兽巢穴场景信息
	OnSceneDoodadInfo           = START_ECODE + 5199, --荒兽巢穴物件信息
	--绝境试炼
	OnPushImpasseLevel			= START_ECODE + 5200,
	--推送协商离婚
	OnPushConsultDivorce		= START_ECODE + 5201,
	--推送离婚结果飘字
	OnPushDivorceResult			= START_ECODE + 5202,
	--推送结婚数据
	OnPushMarryData				= START_ECODE + 5203,
	--跨服彩聊
	OnPushCrossTrumpetCount		= START_ECODE + 5204,
	--推送福气红包
	OnPushCommRedenv			= START_ECODE + 5205,
	--推送播放婚礼剧情
	OnPushMarryAnimation		= START_ECODE + 5206,
	--推送婚礼纳吉
	OnPushMarryLuckWord			= START_ECODE + 5207,
	--推送播放道具特效
	OnPushEffectItem			= START_ECODE + 5208,
	--推送弹幕
	OnPushDanmakuMsg			= START_ECODE + 5209,
	--推送婚礼消息
	OnPushWedding				= START_ECODE + 5210,
	--推送普装部位
	OnPushEquipPart				= START_ECODE + 5211,
	--推送普装套装数据
	OnPushOrangeSuit			= START_ECODE + 5212,
	--推送GM惩罚信息
	OnPushGmPunishData			= START_ECODE + 5213,
	--巡游npc信息
	OnPushCruiseNpcInfo			= START_ECODE + 5214,
	--巡游开启
	OnPushCruiseStart			= START_ECODE + 5215,
	--巡游进入场景信息
	OnPushCruiseSceneInfo		= START_ECODE + 5216,
	--巡游结束
	OnPushCruiseOver			= START_ECODE + 5217,
	--巡游祝福id
	OnPushBlessId			    = START_ECODE + 5218,
	--巡游已发奖励(真正结束 客户端清掉数据用)
	OnPushCruiseRewardOver		= START_ECODE + 5219,
	--幻化系统刷新
	OnPushMagicalTrigger        = START_ECODE + 5220,
	--更新神格数据
	OnPushHaloInfo				= START_ECODE + 5221,
	--更新灵阵数据
	OnPushBattleArrayInfo		= START_ECODE + 5222,
	--转盘类结果推送
	OnActTurnTableResult 		= START_ECODE + 5223,
	--推送跨服BOSS状态
	OnPushBFBossState			= START_ECODE + 5224,
	--推送进出摆摊区域状态
	OnPushStallAreaInOut=START_ECODE + 5225,
	--推送宗派争霸宝珠状态
	OnPushTribalArenaGemState 	= START_ECODE + 5231,
	--推送黑名单
	OnPushBlacks                =START_ECODE + 5232,
	--推送好友申请状态设置
	OnPushApplyState            = START_ECODE + 5233,
	--推送好友同步状态
	OnPushSyncSocially          =START_ECODE + 5334,
	--推送增加的好友
	OnPushAddFriend            =  START_ECODE+5335,
	--推送需要增加的仇人
	OnPushAddEnemy            =  START_ECODE+5336,
	--推送死亡弹框
	OnPushBeKilledWindow = START_ECODE + 5235,
	--推送职位列表
	OnPushCountryPosition = START_ECODE + 5240,
	--推送官员列表
	OnPushOfficials = START_ECODE + 5241,
	--推送国民列表
	OnPushCountryPlayers = START_ECODE + 5242 ,
	--推送禁言囚禁列表
	OnPushJinYanAndImprion = START_ECODE + 5243,
	--推送投票界面
	OnPushVoteWindow   = START_ECODE + 5244,
	
	--宗派信息
	--推送大事记界面数据
	OnPushGangDaShiJi   = START_ECODE + 5245,
	--推送动态界面数据
	OnPushGangDongTai   = START_ECODE + 5246,
	--推送职位后缀
	OnPushPostToSuffix   = START_ECODE + 5247,
	--推送自动加入状态
	OnPushGangAutoState   = START_ECODE + 5248,
	--推送加入限制
	OnPushGangJoinLimit   = START_ECODE + 5249,
	--推送本周薪酬
	OnPushWeekRefresh   = START_ECODE + 5250,
	--推送今日活跃度
	OnPushLiveness   = START_ECODE + 5251,
	--推送个人灵兽居
	OnPushAnimalPosData = START_ECODE + 5252,
	--推送宗派灵兽居
	OnPushAnimalData = START_ECODE + 5253,
	--推送弹窗消息
	OnPushWindow = START_ECODE + 5254,
	--推送地图主要人物信息
	OnPushRadar = START_ECODE +5255,
	--推送宗派技能
	OnPushGangSkill = START_ECODE + 5256,
	
	--推送今日薪酬
	OnPushDayRefresh   = START_ECODE + 5257,
	--推送公告
	OnPushGangNotice   = START_ECODE + 5258,
	--推送城战结算界面
	OnPushNewGangWarResult = START_ECODE + 5259,
	--推送城战开始倒计时
	OnPushGwStartFightTime = START_ECODE + 5260,
	--推送雕像信息
	OnPushGwStatueInfo = START_ECODE + 5261,
	--推送击杀数量
	OnPushGwKillNum = START_ECODE +5262, 
	--推送导航栏信息
	OnPushGwNavigation = START_ECODE +5263, 
	

	OnPushAttainedValue= START_ECODE  + 5301, --推送灵气值

	OnPushCountryWarState= START_ECODE  + 5301, --推送国战开启状态
	--队伍准备界面弹出/关闭
	OnPushTeamVoteSelect= START_ECODE  + 5302, 
	--
	OnPushTeamVoteForce= START_ECODE  + 5303, 
}

--赠送
EventCode.Present = {
	OnDonateItems 			= START_ECODE + 6001, --赠送物品
	OnDonateComplete 		= START_ECODE + 6002, --赠送物品成功
	OnDonateGiftChange 		= START_ECODE + 6003, --赠送道具变化
}

--新手引导
EventCode.PlayerGuide = {
	OnCheckAllGuide 		= START_ECODE + 6051, --检查所有引导
	OnViewVisibleCheck 		= START_ECODE + 6052, --界面可见时通知引导检查相关
	OnFinishGuideStep 		= START_ECODE + 6053, --完成新手引导步骤
	OnHideMainWidget 		= START_ECODE + 6054, --隐藏主界面的控件
	OnEnterTargetGuide 		= START_ECODE + 6055, --开启指定新手引导(场景事件)
	OnCheckNewFuncGuide 	= START_ECODE + 6056, --功能开启引导检查
	OnShowAllButtonTest 	= START_ECODE + 6057, --(测试)显示所有功能按钮
	OnCanGuideDataUpdate 	= START_ECODE + 6058, --未播放引导数据变化
	OnViewUnVisibleCheck 	= START_ECODE + 6059, --界面不可见时通知引导检查相关
	OnPlayNewFuncAction 	= START_ECODE + 6060, --开始播放新功能开启动画
	OnNewFuncActionOver 	= START_ECODE + 6061, --结束播放新功能开启动画
	OnFocusShowUseTip		= START_ECODE + 6062, --显示右下角使用tip
	OnSuspendGuide 			= START_ECODE + 6063, --中断引导
	OnEnterTreasureComplete = START_ECODE + 6064, --进入藏宝洞后特殊检查
	OnEnterTargetGuide2 	= START_ECODE + 6065, --开启指定新手引导(怪物行为)
	OnStopGuide				= START_ECODE + 6066, --结束引导
	OnGuideTaskChange 		= START_ECODE + 6067, --显示主界面的控件
}

EventCode.YHSingle = {
	OnEnter = START_ECODE + 6100,
	OnChangeAI = START_ECODE + 6101,
}

--运营活动刷新
EventCode.OperateAct = {
	OnRefreshRechargeView  = START_ECODE + 6200,
	CloseWindow  = START_ECODE + 6201,
	OnUpdataSevenSignin    = START_ECODE + 6202,
	UpdataActFortunered    = START_ECODE + 6203,
	UpdataActFortuneegg    = START_ECODE + 6204,
	OpenBlessingRedPacket  = START_ECODE + 6205,
	BlessingRedPacketList  = START_ECODE + 6206, 
	UpdataSingleRedData    = START_ECODE + 6208,   --刷新单条红包数据通知
	NewSingleRedData       = START_ECODE + 6209,   --新红包通知
	UpdataBlessingRPList   = START_ECODE + 6210,   --请求更新列表
	UpdataBlessingRankList   = START_ECODE + 6211, --福气排行榜数据
	ClearUpBlessingRed   = START_ECODE + 6212,     --清除主界面福气红包列表第一位
	ShowMainBlessingRed   = START_ECODE + 6213,    --显示主界面福气红包
	AllRedenvCommList   = START_ECODE + 6214,      --红包列表数据
	HideBlessingClick = START_ECODE + 6215,        --关闭主界面福气红包 
	UpdataActMarryFund = START_ECODE + 6216,	   --刷新结婚礼金信息
	UpdataActNewBieRedEnvelope = START_ECODE + 6217,  --刷新新手红包数据
	UpdateDreamlandActivites = START_ECODE + 6218, --幻境活动
	UpdateLuckyTurntable = START_ECODE + 6219,  --更新幸运转盘
	ActivationTurntableData = START_ECODE + 6220,  --激活转盘数据
	UpdateNationalLottery = START_ECODE + 6221, 	--全民抽奖数据更新
	OnPushShowHint = START_ECODE + 6222, 			--运营活动特殊道具获得飘字
	UpdateConsumeActivity = START_ECODE + 6223, 	--累计消费更新
	PushActLuckyTurntablePlayer = START_ECODE + 6224,  --幸运转盘玩家数据
}

--客服
EventCode.Customer = {
	SubmitSucces  = START_ECODE + 6301,
	UpdateQuestion = START_ECODE + 6302,
	UpdateDot = START_ECODE + 6303,
}

--系统解锁事件
EventCode.SystemRoot = {
	OpenSystem = START_ECODE + 7001,
}

--一条龙流程
EventCode.SeriesProcedure = {
	NoTeam = START_ECODE + 7051,
	NotEnoughTM = START_ECODE + 7052,
	TeamNotEnoughTM = START_ECODE + 7053,
	AddTM = START_ECODE + 7054,
	Start = START_ECODE + 7055,
}

--藏宝图
EventCode.Treasure = {
	ShowTip = START_ECODE + 7081,
	StopPlant = START_ECODE + 7082,
	CloseALlTisp = START_ECODE + 7083,
	CloseFastUse = START_ECODE + 7084,
	TipState  = START_ECODE + 7085,
	NotCount  = START_ECODE + 7086,
	LeaveDungeonBtn = START_ECODE + 7087,
	OnDigStateChange = START_ECODE + 7088,
}

--白泽问贤
EventCode.Ask = {
	UpdateAllSubject = START_ECODE + 7101,
	SeekHelpSubject = START_ECODE + 7102,
	SkipDiamondNum = START_ECODE + 7103,
	QuestionId = START_ECODE + 7104,
	HelpSubject = START_ECODE +7105,
	AskHelpClose = START_ECODE + 7106,
	GangHelpClose = START_ECODE +7107,
	AssistPrimary = START_ECODE +7108,
	PrimaryAnswer = START_ECODE +7109,
	ImperialQuestion = START_ECODE +7110,
	AskSkipSucced = START_ECODE +7111,
	PrimaryAskHelp = START_ECODE +7112,
}

--最新消息
EventCode.LatestNews = {
	OnProfBattleData = START_ECODE + 7201,
	OnWarLastVsData = START_ECODE + 7202,
	UpdateWarLastIcon = START_ECODE + 7203,
	OnUpdateNewDots = START_ECODE + 7204,
	OnUpdateEntranceVisible = START_ECODE + 7205,
	OnAskWarLastVsInfo = START_ECODE + 7206,
	OnAskProfBattleResult = START_ECODE + 7207,
	UpdataLatestNewsRanking = START_ECODE + 7208,
	OnDragonBattleData = START_ECODE + 7209,
	OnAskDragonBattle = START_ECODE + 7210,
	OnAskActivityBattle = START_ECODE + 7211,
	OnActivityBattleData = START_ECODE + 7212,
	UpdataLNCombatRank = START_ECODE + 7213,  --战斗力排行榜 
	UpdataLNGangRank = START_ECODE + 7214,    --宗派排行榜
	UpdataLNLvRank = START_ECODE + 7215,      --等级排行榜
	UpdataLNPetRank = START_ECODE + 7216,     --宠物排行榜
}

--修炼丹
EventCode.HandUp = {
	HandUpRepairExp = START_ECODE +7301,
	HandUpGangFire = START_ECODE + 7302,
	OnHandUpShow = START_ECODE + 7303,
	OnHandUpHide = START_ECODE + 7304,
}

--资源
EventCode.Resource = {
	OnDownloadStarted = START_ECODE + 7401,
	OnDownloadFinished = START_ECODE + 7402,
	OnDownloadStopped = START_ECODE + 7403,
	OnDownloadFailed = START_ECODE + 7404,
}

--商会
EventCode.Commerce = {
	OnBagNoArtifactAndEquip = START_ECODE + 7501, --背包中的非普装、核装道具变化
	OnUpdateCommerceWin = START_ECODE + 7502, --刷新商会面板
}

--高级藏宝图
EventCode.HighTreasure = {
	HighTreasureEffect = START_ECODE + 7601,
}

--音效
EventCode.Sound = {
	OnFunctionSound = START_ECODE + 7701, 
}

--战力动画
EventCode.BattleAni = {
	OnAniFinish = START_ECODE + 7801,
}

--跨服战场
EventCode.SpanBattle = {
	OnKillNumChange = START_ECODE + 7901,
	OnBoxDataChange = START_ECODE + 7902,
	OnBattleRankChange = START_ECODE + 7903,
	OnLuckyValueChange = START_ECODE + 7904,
	OnBattleJoinTimeChange = START_ECODE + 7905,
	OnBattleRealHpChange = START_ECODE + 7906,
	OnBattleFakeNumChange = START_ECODE + 7907,
	OnBattleFakeHpChange = START_ECODE + 7908,
	OnBattleServerDamageChange = START_ECODE + 7909,
	OnBattleGangDamageChange = START_ECODE + 7910,
	OnCaveChipNumChange = START_ECODE + 7911,
	OnUpdateCaveKillTexts = START_ECODE + 7912,
	OnUpdateReciveRedDots = START_ECODE + 7913,
	OnCavePosInfoChange = START_ECODE + 7914,
	OnBossPosInfoChange = START_ECODE + 7915,
	OnRealPosStatusChange = START_ECODE + 7916,
	OnFakePosStatusChange = START_ECODE + 7917,
	OnBattleRealNumChange = START_ECODE + 7918,
	OnFakeGangDamageChange = START_ECODE + 7919,
	OnBattlefieldSoulState = START_ECODE + 7920,
}
--人物状态
EventCode.HeroState = {
	OnHeroShowWindow = START_ECODE + 8001,
}

--名门宗派
EventCode.Privilege = {
	OnGangActivityPos =START_ECODE + 8101,
	OnUpdatePrivilegeStats =START_ECODE + 8102,
	OnUpdatePrivilegeMain = START_ECODE + 8103,
	OnClosePrivilege = START_ECODE + 8104,
	OnGangPrivilegeDot = START_ECODE + 8105,
	OnGangPosRankData = START_ECODE + 8106,
}
--共舞
EventCode.Dance = {
	OnInOutDanceArea = START_ECODE + 8201,
	OnUpdataBtnState = START_ECODE + 8202,
	OnJoinClickCD =  START_ECODE + 8203,
}
--诛仙剑阵
EventCode.ZhuXian = {
	OnRandomResult = START_ECODE + 8301,
	OnUpdateZhuXianMain = START_ECODE +8302,
	OnUpdateZhuXianTime = START_ECODE +8303,
	OnZhiXianPrcious = START_ECODE +8304,
}

--异族
EventCode.AlienInvasion = {
	Info = START_ECODE + 8401,
	OnSelectIndex = START_ECODE + 8402,
	--buff提示
	OnPushBuffTips = START_ECODE + 8403,
	--
	OnPushUpDataHead = START_ECODE + 8404,
}
--翅膀
EventCode.Wing = {
	OnActTimeChange = START_ECODE + 8501,
	OnLuckValueChange = START_ECODE + 8502,
	OnStrengLvChange = START_ECODE + 8503,
	OnChangeIdChange = START_ECODE + 8504,
	OnWingDataChange = START_ECODE + 8505,
	OnWingMaterialChange = START_ECODE + 8506,
	OnChangeWingModel = START_ECODE + 8507,
	OnSkillLvlChange = START_ECODE + 8508,
	OnShowBigCritEffect = START_ECODE + 8509,
	OnShowCritEffect = START_ECODE + 8510,
	OnShowStrengthEffect = START_ECODE + 8511,
	OnShowSuccessEffect = START_ECODE + 8512,
	OnStrengthRedDot = START_ECODE + 8513,
	OnStageRedDot = START_ECODE + 8514,
	OnSkillRedDot = START_ECODE + 8515,
	OnChangeRedDot = START_ECODE + 8516,
	OnRedDotChange = START_ECODE + 8517,
	OnWingPowerChange = START_ECODE + 8518,
	OnShowStageEffect = START_ECODE + 8519,
}

--招财猫
EventCode.FortuneCat = {
	OnUpdateFortuneCatList = START_ECODE +8601,
}

--轩辕传奇
EventCode.Legends = {
	OnUpdateLegendsData = START_ECODE + 8701,
	OnUpdateDrawLottery = START_ECODE + 8702,
	OnChangeInterface = START_ECODE +8703,
	OnChangeState = START_ECODE +8704,
	OnRandomResult = START_ECODE + 8705,
	OnReulusRank = START_ECODE + 8706,
	OnBoxGetResult = START_ECODE + 8707,
	OnNextSend = START_ECODE + 8708,
}

--羽化登仙
EventCode.Apotheosis = {
	OnUpdateLegendsData = START_ECODE + 8801,
	OnUpdateDrawLottery = START_ECODE + 8802,
	OnChangeInterface = START_ECODE +8803,
	OnChangeState = START_ECODE +8804,
	OnRandomResult = START_ECODE + 8805,
	OnReulusRank = START_ECODE + 8806,
	OnBoxGetResult = START_ECODE + 8807,
	OnNextSend = START_ECODE + 8808,
	OnWindsChange = START_ECODE + 8809,
}

EventCode.OneKey = {
	OnOneKeyDataUpdate 		= START_ECODE +8901,
}

--绝境试炼
EventCode.DespairTrial = {
	FirstPass = START_ECODE + 9001,
	SingleCustomPass = START_ECODE + 9002,
	TeamCustomPass = START_ECODE + 9003,
}

EventCode.Map = {
	OnCheckCountryMap = START_ECODE + 9050,
	OnCheckSceneMap = START_ECODE + 9051,
}

--荒兽巢穴
EventCode.MonsterLair = {
	OnUpdateAwardInfo           = START_ECODE + 9100, --刷新荒兽巢穴奖励信息
	OnOpenAwardInfoWidget       = START_ECODE + 9101, --打开奖励物品界面
	OnCreateLeftWidget          = START_ECODE + 9102, --生成左边任务界面
	OnHideLeftWidget            = START_ECODE + 9103, --隐藏左边任务界面
	OnSweepOwnership            = START_ECODE + 9104, --清除归属
	OnMonsterDataUpdate			= START_ECODE + 9105, --怪物信息更新
	OnSceneDoodadData			= START_ECODE + 9106, --怪物doodad更新
	OnUpdateTired               = START_ECODE + 9107, --刷新玩家疲劳值
}

--结婚
EventCode.Marry = {
	OnUpdateLeftPanel = START_ECODE + 9201, --刷新结婚任务栏
	OnUpdateRingData = START_ECODE + 9202, --刷新戒指数据
	OnUpdatePartnerOutLook = START_ECODE + 9203, --刷新伴侣外观模型
	OnShowRoseEffect = START_ECODE + 9204, --显示玫瑰花特效v
	OnEntranceDotsChange = START_ECODE + 9205, --显示入口红点刷新
	OnGownDotsChange = START_ECODE + 9206, --折扣时装购买红点刷新
	OnInitGownDots = START_ECODE + 9207, --初始化折扣时装购买红点(仅在每次登陆时)
	OnSkipFundWidget = START_ECODE + 9208,  --跳转到礼金界面
	OnShowFundMarkRed = START_ECODE + 9209,  --显示结婚礼金标志红点
	OnShowFundGetRed = START_ECODE + 9210,  --显示结婚礼金领取红点
	OnMarryFundMarkShow = START_ECODE + 9211,  --显示结婚礼金标志
	OnShowFundWindow = START_ECODE + 9212,  --显示结婚窗口
	OnUpdateCruiseInfo = START_ECODE + 9213,  --巡游信息返回通知
	OnUpdateCruiseBlessList = START_ECODE + 9214,  --巡游祝福列表
	OnUpdateFCNumChange = START_ECODE + 9215,  --巡游付费烟花和喜糖数量变更
	OnUpdateCruiseSceneInfo = START_ECODE + 9216,  --巡游场景数据
	OnUpdateCruiseSuccess = START_ECODE + 9217,  --巡游请求成功
	OnShowCruiseEffect = START_ECODE + 9218,  --巡游烟花特效
	OnAskCruiseNpcInfo = START_ECODE + 9219,  --请求巡游npc位置
	OnUpdateBNumChange = START_ECODE + 9220,  --巡游祝福道具
	OnUpdateCruiseEnd = START_ECODE + 9221,  --巡游结束
}

--角色活动提醒
EventCode.RoleRemind = {
	OnUpdateInterface 		= START_ECODE + 9301, --更新界面
}

--惩罚信息
EventCode.GMPunish = {
	OnUpdateGmPunish		= START_ECODE + 9401, --更新惩罚信息界面
}

--神秘商店
EventCode.MysteryStore = {
	UpdateMysticalShop = START_ECODE + 9601,		--神秘商店刷新
	OnMysteryEndTimeState = START_ECODE + 9602,		--神秘商店结束状态发送
}

--成长活动更新(坐骑)
EventCode.GrowUpUpdate = {
	OnUpdateChange  		= START_ECODE + 9701, --更新翅膀，灵器，神兵
	OnUpdateShowType		= START_ECODE + 9702, --更新模型状态
	OnGodHeadUseSuccess 	= START_ECODE + 9703, --神格增加属性道具使用成功
	OnGodSignUseSuccess 	= START_ECODE + 9704, --神迹增加属性道具使用成功
	OnUpdateBeastItems		= START_ECODE + 9705, --更新兽灵道具
	OnBeastOpenUpdate 		= START_ECODE + 9706, --更新兽灵开放系统
	OnWingMaterialChange 	= START_ECODE + 9707, --更新翅膀
	OnUpdateSoalArrayState  = START_ECODE + 9708, --更新灵阵
}
--幻化
EventCode.Variant = {
	OnActive = START_ECODE + 9801,  --激活 升星
	OnUse = START_ECODE + 9802,  --幻化
	OnUpDataUI = START_ECODE + 9803,--刷新界面
	OnUpDataItem = START_ECODE + 9804,--道具更新
	OnUpLvUp = START_ECODE + 9805,--升级更新
	OnUpLvUpUI = START_ECODE + 9806,--升级更新
	OnUpDataAllUI = START_ECODE + 9807,--刷新界面
}

EventCode.Menu=
{
   MenuInof   =START_ECODE + 9901 ,   -- 更新好友名片信息菜单
}

EventCode.Country = {
	OnUpdateNotice = START_ECODE + 10004,
	OnUpDataCountryInfo = START_ECODE + 10005,
	OnUpDataOfficialInfo = START_ECODE +10006,
	OnUpdateVoteNum = START_ECODE + 10009,
	OnUpdateTotal = START_ECODE + 10010,
	OnUpDataBanImprList = START_ECODE + 10011,
	OnResign = START_ECODE + 10012,
	OnSendMoney = START_ECODE + 10013,
}

EventCode.CountryWar= {
	OnStartCountryWar= START_ECODE + 10052, -- 国战开始通知
	OnCloseUiCountryWar= START_ECODE + 10053, -- 国战关闭界面事件
}

return EventCode