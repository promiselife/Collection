--[["
	desc: push消息-映射表
	author: oyxz
	since: 2015-12-18
	copyright: xingchen
 "]]
local msgtype = require 'inc.def.msgtype'
local EventCode = require 'cfg.EventCode'

local PushDefine = {}

local PushEvents = {
    [msgtype.defines.DungeonStar] = EventCode.Push.OnPushDungeonStar,
    --[msgtype.defines.DungeonStatus] 			= EventCode.Push.OnPushDungeonStatus,
    [msgtype.defines.PushWindow] = EventCode.Push.OnPushWindow,
    [msgtype.defines.PushDungeonStart] = EventCode.Push.OnPushDungeonStart,
    [msgtype.defines.ItemSync] = EventCode.Push.OnPushItemSync,
    [msgtype.defines.PushMail] = EventCode.Push.OnPushMailSync,
    [msgtype.defines.ChatData] = EventCode.Push.OnPushChatData,
    [msgtype.defines.FreeWorldChat] = EventCode.Push.OnPushFreeWorldChat,
    [msgtype.defines.MallDataSync] = EventCode.Push.OnPushMallDataSync,
    [msgtype.defines.ErrorCode] = EventCode.Push.OnPushErrorCode,
    [msgtype.defines.TrumpetChatData] = EventCode.Push.OnPushColorChatCount,
    [msgtype.defines.PracticeTime] = EventCode.Push.OnPushPracticeTime,
    [msgtype.defines.PracticeItemData] = EventCode.Push.OnPushPracticeItem,
    [msgtype.defines.PushItemUseInfo] = EventCode.Push.OnPushItemUseInfo,
    [msgtype.defines.PushFriends] = EventCode.Push.OnPushFriendList,
    [msgtype.defines.PushApplys] = EventCode.Push.OnPushFriendInvite,
    [msgtype.defines.PushEnemys] = EventCode.Push.OnPushEnemyList,
	[msgtype.defines.PushApplyState] = EventCode.Push.OnPushApplyState,
	[msgtype.defines.PushSyncSocially] = EventCode.Push.OnPushSyncSocially,
	[msgtype.defines.PushAddFriend] = EventCode.Push.OnPushAddFriend,	
	[msgtype.defines.PushAddEnemy] = EventCode.Push.OnPushAddEnemy,	
	[msgtype.defines.PushBeKilledWindow] = EventCode.Push.OnPushBeKilledWindow,
    [msgtype.defines.PushRevengeData] = EventCode.Push.OnPushRevengeData,
    [msgtype.defines.PushAuctionItem] = EventCode.Push.OnPushAuctionItem,
    [msgtype.defines.PushAuctionPriceChange] = EventCode.Push.OnPushAuctionPriceChange,
    [msgtype.defines.PushAuctionStatus] = EventCode.Push.OnPushAuctionStatus,
	--宗派基本信息
    [msgtype.defines.PushGangBase] = EventCode.Push.OnPushGangBase,
    [msgtype.defines.PushGangExtraData] = EventCode.Push.OnPushGangExtraData,
	--宗派成员信息
    [msgtype.defines.PushGangMembers] = EventCode.Push.OnPushGangMembers,
	--宗派列表
    [msgtype.defines.PushGangList] = EventCode.Push.OnPushGangList,
	--宗派申请列表
    [msgtype.defines.PushGangApplys] = EventCode.Push.OnPushGangApplys,
    [msgtype.defines.PushGangContributions] = EventCode.Push.OnPushGangContributions,
	--宗派玩家自身信息
    [msgtype.defines.PushGangPlayerInfo] = EventCode.Push.OnPushGangPlayerInfo,
    [msgtype.defines.PushAllMarketData] = EventCode.Push.OnPushAllMarketData,
	--宗派全部数据
    [msgtype.defines.PushGangAllData] = EventCode.Push.OnPushGangAllData,
    [msgtype.defines.PushPlayerMarket] = EventCode.Push.OnPushPlayerMarket,
    [msgtype.defines.PushServerLvl] = EventCode.Push.OnPushServerLvl,
    [msgtype.defines.PushServerDay] = EventCode.Push.OnPushServerDay,
    [msgtype.defines.PushDungeonResult] = EventCode.Push.OnPushDungeonResult,
    [msgtype.defines.PushLeaveDungeon] = EventCode.Push.OnPushLeaveDungeon,
    [msgtype.defines.PushGangCampfireData] = EventCode.Push.OnPushGangCampfireData,
    [msgtype.defines.PushQuestionData] = EventCode.Push.OnPushQuestionData,
    [msgtype.defines.PushAnswerQuestionTime] = EventCode.Push.OnPushAnswerQuestionTime,
    [msgtype.defines.EntityBeKilled] = EventCode.Push.OnPushEntityBeKilled,
    [msgtype.defines.PushRedenvUpdate] = EventCode.Push.OnPushRedenvUpdate,
    [msgtype.defines.EntityConKill] = EventCode.Push.OnPushEntityConKill,
    [msgtype.defines.PushGenderTagState] = EventCode.Push.OnPushGenderTagState,
	--大事记界面数据
	[msgtype.defines.PushGangDaShiJi] = EventCode.Push.OnPushGangDaShiJi,
	--动态界面数据
	[msgtype.defines.PushGangDongTai] = EventCode.Push.OnPushGangDongTai,
	--职位后缀
	[msgtype.defines.PushPostToSuffix] = EventCode.Push.OnPushPostToSuffix,
	--自动加入状态
	[msgtype.defines.PushGangAutoState] = EventCode.Push.OnPushGangAutoState,
	--加入限制
	[msgtype.defines.PushGangJoinLimit] = EventCode.Push.OnPushGangJoinLimit,
	--宗派薪酬
	--本周奖金
	[msgtype.defines.PushWeekRefresh] = EventCode.Push.OnPushWeekRefresh,
	--今日奖金
	[msgtype.defines.PushDayRefresh] = EventCode.Push.OnPushDayRefresh,
	
	--今日活跃度
	[msgtype.defines.PushLiveness] = EventCode.Push.OnPushLiveness,
	--个人灵兽居
	[msgtype.defines.PushAnimalPosData] = EventCode.Push.OnPushAnimalPosData,
	--宗派灵兽居
	[msgtype.defines.PushAnimalData] = EventCode.Push.OnPushAnimalData,
	--建筑列表
	[msgtype.defines.PushGangBuildings] = EventCode.Push.OnPushGangBuildings,
	--宗派技能
	[msgtype.defines.PushGangSkill] = EventCode.Push.OnPushGangSkill,
	--宗派公告
	[msgtype.defines.PushGangNotice] = EventCode.Push.OnPushGangNotice,
	--城战结算界面
	[msgtype.defines.PushNewGangWarResult] = EventCode.Push.OnPushNewGangWarResult,
	--城战开始倒计时
	[msgtype.defines.PushGwStartFightTime] = EventCode.Push.OnPushGwStartFightTime,
	--推送雕像信息
	[msgtype.defines.PushGwStatueInfo] = EventCode.Push.OnPushGwStatueInfo,
	--推送击杀数量
	[msgtype.defines.PushGwKillNum] = EventCode.Push.OnPushGwKillNum,
	--推送导航栏信息
	[msgtype.defines.PushGwNavigation] = EventCode.Push.OnPushGwNavigation,
	
	
    --组队
    [msgtype.defines.PushTeam] = EventCode.Push.OnPushTeamDataSync,
    [msgtype.defines.TeamOperData] = EventCode.Push.OnPushTeamSingleDataSync,
    [msgtype.defines.TeamInvite] = EventCode.Push.OnPushTeamInviteSync,
    [msgtype.defines.TeamApply] = EventCode.Push.OnPushTeamApplyDataSync,
	[msgtype.defines.TeamInviteToMember] = EventCode.Push.OnPushTeamInviteToMember,
	[msgtype.defines.PushTeamVoteSelect] = EventCode.Push.OnPushTeamVoteSelect,
	[msgtype.defines.PushTeamVoteForce] = EventCode.Push.OnPushTeamVoteForce,
	--境界
	[msgtype.defines.PushAttainedValue] = EventCode.Push.OnPushAttainedValue,
    --神器
    [msgtype.defines.PushArtifactStar] = EventCode.Push.OnPushArtifactStar,
    --魔将
    [msgtype.defines.PushGeneralList] = EventCode.Push.OnPushGeneralList,
    [msgtype.defines.PushGeneralDamages] = EventCode.Push.OnPushGeneralDamages,
    [msgtype.defines.PushActivityStateList] = EventCode.Push.OnPushActivityStateList,
    [msgtype.defines.PushActivityState] = EventCode.Push.OnPushActivityState,
    --任务
    [msgtype.defines.PushTaskList] = EventCode.Push.OnPushTaskList,
    [msgtype.defines.PushTaskHelpList] = EventCode.Push.OnPushTaskHelpList,
    [msgtype.defines.PushTaskAssistCount] = EventCode.Push.OnPushAssistCount,
    [msgtype.defines.PushBeHelpList] = EventCode.Push.OnPushBeHelpList,
    --[msgtype.defines.LootInfo]					= EventCode.Push.OnLootInfo,

    [msgtype.defines.PushNewGest] = EventCode.Push.OnPushNewGest,
    [msgtype.defines.PushTitleList] = EventCode.Push.OnPushTitleList,
    [msgtype.defines.PushDrawRewardInfo] = EventCode.Push.OnPushDrawRewardInfo,
    --血脉
    [msgtype.defines.PushBloodlineData] = EventCode.Push.OnPushBloodlineData,
    [msgtype.defines.PushAcupointData] = EventCode.Push.OnPushAcupointData,
    --传功
    [msgtype.defines.PushImpartInfo] = EventCode.Push.OnPushImpartInfo,
    [msgtype.defines.PushImpartReqList] = EventCode.Push.OnPushImpartReqList,
    --[msgtype.defines.PushImpartPlayerInfos]		= EventCode.Push.OnPushImpartPlayerInfos,
    [msgtype.defines.PushImpartConfirmInfo] = EventCode.Push.OnPushImpartConfirmInfo,
    --攻城战竞价
    [msgtype.defines.PushMaxBidingChange] = EventCode.Push.OnPushMaxBidingChange,
    [msgtype.defines.PushGangWarResult] = EventCode.Push.OnPushGangWarResult,
    [msgtype.defines.PushSceneTotemStaus] = EventCode.Push.OnPushSceneTotemStaus,
    --野外Boss
    [msgtype.defines.PushWildBossData] = EventCode.Push.OnPushWildBossData,
    --世界boss
    [msgtype.defines.PushWorldbossLog] = EventCode.Push.OnPushWorldbossLog,
    [msgtype.defines.PushPersonLog] = EventCode.Push.OnPushPersonLog,
    [msgtype.defines.PushBossLastTime] = EventCode.Push.OnPushBossLastTime,
    [msgtype.defines.PushPersonInfo] = EventCode.Push.OnPushPersonInfo,
    -- [msgtype.defines.PushBossScore]				= EventCode.Push.OnPushBossScore,
    [msgtype.defines.PushLootTime] = EventCode.Push.OnPushLootTime,
    [msgtype.defines.PushBossChallengeStart] = EventCode.Push.OnPushBossChallengeStart,
    [msgtype.defines.WorldBossActEnd] = EventCode.Push.OnPushWorldBossActEnd,
    [msgtype.defines.PushSceneProgress] = EventCode.Push.OnPushSceneProgress,
    [msgtype.defines.PushSceneWord] = EventCode.Push.OnPushSceneWord,
    [msgtype.defines.PushSceneInfo] = EventCode.Push.OnPushSceneInfo,
    --炎黄战场
    [msgtype.defines.PushArenaEnterNum] = EventCode.Push.OnPushArenaEnterNum,
    [msgtype.defines.PushArenaData] = EventCode.Push.OnPushArenaData,
    [msgtype.defines.PushArenaResult] = EventCode.Push.OnPushArenaResult,
    [msgtype.defines.PushArenaKill] = EventCode.Push.OnPushArenaKill,
    [msgtype.defines.PushArenaCampScore] = EventCode.Push.OnPushArenaCampScore,
    [msgtype.defines.PushActMapTime] = EventCode.Push.OnPushActMapTime,
    [msgtype.defines.SyncPetInfo] = EventCode.Push.OnPushPetData,
    --活动
    [msgtype.defines.PushLivenessInfo] = EventCode.Push.OnPushActivityValues,
    [msgtype.defines.ResetLivenessInfo] = EventCode.Push.ResetLivenessInfo,
    [msgtype.defines.PushDailyAct] = EventCode.Push.PushDailyAct,
    [msgtype.defines.PushActivityJoin] = EventCode.Push.OnPushActivityJoin,
    [msgtype.defines.PushGangEliteNums] = EventCode.Push.OnPushGangEliteNums,
    [msgtype.defines.PushGangPrivileges] = EventCode.Push.OnPushGangPrivileges,
    --坐骑
    [msgtype.defines.PushMountsInfo] = EventCode.Push.OnPushMountsInfo,
    --时装
    [msgtype.defines.SyncFashionList] = EventCode.Push.OnPushSyncFashionData,
    [msgtype.defines.SyncEquipFashion] = EventCode.Push.OnPushSyncEquipFashion,
    --Vip
    [msgtype.defines.PushDoubleCharge] = EventCode.Push.OnPushDoubleCharge,
    [msgtype.defines.PushVipGiftData] = EventCode.Push.OnPushVipGiftData,
    --门派竞技
    [msgtype.defines.PushProCurStatus] = EventCode.Push.OnPushProCurStatus,
    [msgtype.defines.PushProBattleInfo] = EventCode.Push.OnPushProBattleInfo,
    [msgtype.defines.PushTransmit] = EventCode.Push.OnPushTransmit,
    [msgtype.defines.PushRingResult] = EventCode.Push.OnPushRingResult,
    [msgtype.defines.PushRingSupport] = EventCode.Push.OnPushRingSupport,
    [msgtype.defines.PushRingInfo] = EventCode.Push.OnPushRingInfo,
    [msgtype.defines.PushRingWatch] = EventCode.Push.OnPushRingWatch,
    [msgtype.defines.PushPlayerRingStatus] = EventCode.Push.OnPushPlayerRingStatus,
    --角色信息
    [msgtype.defines.PushChangeNameCount] = EventCode.Push.OnPushChangeNameCount,
    [msgtype.defines.PushSercurityLockData] = EventCode.Push.OnPushSercurityLockData,
    --生活技能
    [msgtype.defines.PushLifeSkills] = EventCode.Push.OnPushLifeSkills,
    [msgtype.defines.PushTrainStatus] = EventCode.Push.OnPushTrainStatus,
    --大荒榜数据刷新
    [msgtype.defines.PushWildrankTime] = EventCode.Push.OnPushWildrankTime,
    [msgtype.defines.PushDamageRecord] = EventCode.Push.OnPushDamageRecord,
    [msgtype.defines.PushChallengeList] = EventCode.Push.OnPushChallengeList,
    [msgtype.defines.PushWildrankReward] = EventCode.Push.OnPushWildrankReward,
    [msgtype.defines.PushWildrankVipCount] = EventCode.Push.PushWildrankVipCount,
    --成就数据
    [msgtype.defines.PushAchievement] = EventCode.Push.OnPushAchievement,
    --爬塔
    [msgtype.defines.PushClimbTowerData] = EventCode.Push.OnPushClimbTowerData,
    --福利(奖励回收)
    [msgtype.defines.PushRewardFind] = EventCode.Push.OnPushRewardFind,
    --福利(离线经验)
    [msgtype.defines.PushOfflineExpData] = EventCode.Push.OnPushOfflineExpData,
    --福利(签到)
    [msgtype.defines.PushSignInData] = EventCode.Push.OnPushSignInData,
    --福利(聚宝盆)
    [msgtype.defines.PushFreeCorncupia] = EventCode.Push.OnPushFreeCorncupia,
    --藏宝图
    [msgtype.defines.PushTreasureInvite] = EventCode.Push.OnPushTreasureInvite,
    [msgtype.defines.PushTreasueState] = EventCode.Push.OnPushTreasueState,
    --通天塔
    [msgtype.defines.PushTowerReadyData] = EventCode.Push.OnPushTowerReadyData,
    [msgtype.defines.PushTowerScoreData] = EventCode.Push.OnPushTowerScoreData,
    [msgtype.defines.PushTowerStateData] = EventCode.Push.OnPushTowerStateData,
    [msgtype.defines.PushTowerfightSettle] = EventCode.Push.OnPushTowerfightSettle,
    --聊天广播
    [msgtype.defines.PushBroadcast] = EventCode.Push.OnPushBroadcast,
    --缘分推送
    [msgtype.defines.PushLotAttained] = EventCode.Push.OnPushFriendLuck,
    --剧情对话
    [msgtype.defines.PushStoryDialogue] = EventCode.Push.OnPushStoryDialogue,
    --推送队友喝酒消息
    [msgtype.defines.PushUseWineItem] = EventCode.Push.OnPushUseWineItem,
    --推送骰子结果
    [msgtype.defines.PushDiceResult] = EventCode.Push.OnPushDiceResult,
    --推送宗派商城数据
    [msgtype.defines.GangMallDataSync] = EventCode.Push.OnPushGangMallData,
    [msgtype.defines.PushGangInvite] = EventCode.Push.OnPushGangInvite,
    --通缉
    [msgtype.defines.PushOpenWanted] = EventCode.Push.OnPushOpenWanted,
    [msgtype.defines.PushWantedList] = EventCode.Push.OnPushWantedList,
    [msgtype.defines.PushWantedState] = EventCode.Push.OnPushWantedState,
    --推送副本结束
    [msgtype.defines.PushDungeonReadyOver] = EventCode.Push.OnPushDungeonReadyOver,
    --红点推送
    [msgtype.defines.PushRedNotice] = EventCode.Push.OnPushRedNotice,
    --藏宝图采集次数
    [msgtype.defines.PushTreasureCollect] = EventCode.Push.PushTreasureCollect,
    --修炼丹BUFF
    [msgtype.defines.PushPracticeExp] = EventCode.Push.OnPushPracticeExp,
    --新手引导数据
    [msgtype.defines.PushNewGuideData] = EventCode.Push.OnPushNewGuideData,
    --附魔
    [msgtype.defines.PushEnchantData] = EventCode.Push.OnPushEnchantData,
    --物品掉落
    [msgtype.defines.PushRewardDraw] = EventCode.Push.OnPushRewardDraw,
    --推送传功数据
    [msgtype.defines.PushImpartData] = EventCode.Push.OnPushImpartData,
    --推送经验增加飘字
    [msgtype.defines.PushExpAdd] = EventCode.Push.OnPushExpAdd,
	--黑名单信息
	[msgtype.defines.PushBlacks] = EventCode.Push.OnPushBlacks,
    --召集跟随
    [msgtype.defines.PushTeamCallTogether] = EventCode.Push.OnPushTeamCallTogether,
    --运营活动推送
    [msgtype.defines.UpdateActivityInfo] = EventCode.Push.OnUpdateActivityInfo,
     --奖励变化
    [msgtype.defines.UpdateAddActivity] = EventCode.Push.OnUpdateAddActivity,
     --新的活动开启
    [msgtype.defines.UpdateActivityStatus] = EventCode.Push.OnUpdateActivityStatus,
     --活动开始 活动结束推送
    --赠送物品日结
    [msgtype.defines.PushDonateCount] = EventCode.Push.OnPushDonateCount,
    [msgtype.defines.PushRingStatus] = EventCode.Push.OnPushRingStatus,
    [msgtype.defines.PushTeamFollowPos] = EventCode.Push.OnPushTeamFollowPos,
    [msgtype.defines.PushWildrankMonster] = EventCode.Push.OnPushWildrankMonster,
    --万能碎片转化次数
    [msgtype.defines.PushTransformCount] = EventCode.Push.OnPushTransformCount,
    [msgtype.defines.PushGmAnswerPlayer] = EventCode.Push.OnPushGmAnswerPlayer,
    --追击荒兽提示信息
    [msgtype.defines.PushChaseWildboss] = EventCode.Push.OnPushChaseWildboss,
    --协助成功返回答题角色
    [msgtype.defines.PushImperialQuestions] = EventCode.Push.OnPushImperialQuestion,
    --珍品摆摊
    [msgtype.defines.UpdatePlayerTreasureMarket] = EventCode.Push.OnUpdatePlayerTreasureMarket,
    [msgtype.defines.UpdateTreasureMarket] = EventCode.Push.OnUpdateTreasureMarket,
    [msgtype.defines.UpdateAttentionTreasure] = EventCode.Push.OnUpdateAttentionTreasure,
    --拍卖分配
    [msgtype.defines.PushAuctionDisInfo] = EventCode.Push.OnPushAuctionDisInfo,
    [msgtype.defines.PushAuctionReady] = EventCode.Push.OnPushAuctionReady,
    [msgtype.defines.AliveCheck] = EventCode.Push.OnPushAliveCheck,
    --当前进行中的魔将全击败
    [msgtype.defines.PushGeneralKillAll] = EventCode.Push.OnPushGeneralKillAll,
    --当前宗派联盟状态
    [msgtype.defines.PushGeneralUnionStatus] = EventCode.Push.OnPushGeneralUnionStatus,
    --已击败第一层boss
    [msgtype.defines.PushKillGeneralFirstBoss] = EventCode.Push.OnPushKillGeneralFirstBoss,
    --下一层是否已开启
    [msgtype.defines.PushNextFloorIsOpen] = EventCode.Push.OnPushNextFloorIsOpen,
    --队伍队长发呆信息
    [msgtype.defines.PushTeamLeaderState] = EventCode.Push.OnPushTeamLeaderState,
    --替换队长弹窗
    [msgtype.defines.PushReplaceMember] = EventCode.Push.OnPushReplaceMember,
    --跨服荒兽数据
    [msgtype.defines.PushCrossWildBossData] = EventCode.Push.OnPushCrossWildBossData,
    --跨服战场
    [msgtype.defines.PushBattleBoxData] = EventCode.Push.OnPushBattleBoxData,
    [msgtype.defines.PushBattleFieldData] = EventCode.Push.OnPushBattleFieldData,
    [msgtype.defines.PushCaveKeyNum] = EventCode.Push.OnPushCaveKeyNum,
    --聊天框切换
    [msgtype.defines.PushChatBubbles] = EventCode.Push.OnPushChatBubbles,
    --推送进出摆摊区域
    [msgtype.defines.PushBaiTanAreaInOut] = EventCode.Push.OnPushStallAreaInOut,
    --共舞 （进入区域）
    [msgtype.defines.PushDanceAreaInOut] = EventCode.Push.OnPushDanceAreaInOut,
    --共舞 跳舞信息
    [msgtype.defines.PushDanceInfo] = EventCode.Push.OnPushDanceInfo,
    [msgtype.defines.PushGeneralPosInfo] = EventCode.Push.OnPushGeneralPosInfo,
    --侵袭boss数据
    [msgtype.defines.PushEliteBossState] = EventCode.Push.OnPushEliteBossState,
    --地洞状态和坐标
    [msgtype.defines.PushBattleCaveStatus] = EventCode.Push.OnPushBattleCaveStatus,
    --战场BOSS状态和坐标
    [msgtype.defines.PushBattleBossStatus] = EventCode.Push.OnPushBattleBossStatus,
    --异族
    [msgtype.defines.PushRaceInvadeNpcInfo] = EventCode.Push.OnPushRaceInvadeNpcInfo,
    [msgtype.defines.PushRaceInvadeFirstEnter] = EventCode.Push.OnPushRaceInvadeFirstEnter,
    --翅膀
    [msgtype.defines.PushWingData] = EventCode.Push.OnPushWingData,
    --修炼丹
    [msgtype.defines.PushPracticeData] = EventCode.Push.OnPushPracticeData,
    --一键完成
    [msgtype.defines.PushOneKeyInfo] = EventCode.Push.OnPushOneKeyInfo,
    --荒兽巢穴
    [msgtype.defines.PushSceneNestInfo] = EventCode.Push.OnPushSceneNestInfo,
     -- 荒兽巢穴场景信息
    [msgtype.defines.PushSceneDoodadInfo] = EventCode.Push.OnSceneDoodadInfo, -- 荒兽巢穴物件信息
    --绝境挑战自己单人和组队数据
    [msgtype.defines.PushImpasseLevel] = EventCode.Push.OnPushImpasseLevel,
    --结婚
    [msgtype.defines.PushMarryData] = EventCode.Push.OnPushMarryData,
    [msgtype.defines.PushProposeInfo] = EventCode.Push.OnPushProposeInfo,
    [msgtype.defines.PushProposeResult] = EventCode.Push.OnPushProposeResult,
    [msgtype.defines.PushBlessInfo] = EventCode.Push.OnPushBlessInfo,
    [msgtype.defines.PushConsultDivorce] = EventCode.Push.OnPushConsultDivorce,
    [msgtype.defines.PushDivorceResult] = EventCode.Push.OnPushDivorceResult,
    [msgtype.defines.PushMarryAnimation] = EventCode.Push.OnPushMarryAnimation,
    [msgtype.defines.PushMarryLuckWord] = EventCode.Push.OnPushMarryLuckWord,
    [msgtype.defines.PushEffectItem] = EventCode.Push.OnPushEffectItem,
    [msgtype.defines.PushWedding] = EventCode.Push.OnPushWedding,
    [msgtype.defines.PushCruiseStart] = EventCode.Push.OnPushCruiseStart,
    [msgtype.defines.PushBlessId] = EventCode.Push.OnPushBlessId,
    [msgtype.defines.PushCruiseSceneInfo] = EventCode.Push.OnPushCruiseSceneInfo,
    [msgtype.defines.PushCruiseOver] = EventCode.Push.OnPushCruiseOver,
    --福气红包
    [msgtype.defines.PushCommRedenv] = EventCode.Push.OnPushCommRedenv,
    --弹幕
    [msgtype.defines.PushDanmakuMsg] = EventCode.Push.OnPushDanmakuMsg,
    --普装部位数据
    [msgtype.defines.PushEquipPart] = EventCode.Push.OnPushEquipPart,
    --普装套装数据
    [msgtype.defines.PushOrangeSuit] = EventCode.Push.OnPushOrangeSuit,
    --GM惩罚信息
    [msgtype.defines.PushGmPunishData] = EventCode.Push.OnPushGmPunishData,
    --巡游npc信息
    [msgtype.defines.PushCruiseNpcInfo] = EventCode.Push.OnPushCruiseNpcInfo,
    --巡游已发奖励(真正结束 客户端清掉数据用)
    [msgtype.defines.PushCruiseRewardOver] = EventCode.Push.OnPushCruiseRewardOver,
    --运营活动特殊道具获得飘字
    [msgtype.defines.ActWindWordsPlayer] = EventCode.OperateAct.OnPushShowHint,
    --转盘类活动结果
    [msgtype.defines.ActTurnTableResult] = EventCode.Push.OnActTurnTableResult,
    --幸运转盘玩家数据
    [msgtype.defines.ActLuckyTurntablePlayer] = EventCode.OperateAct.PushActLuckyTurntablePlayer,
    --推送跨服BOSS状态
    [msgtype.defines.PushBFBossState] = EventCode.Push.OnPushBFBossState,
    --推送宗派争霸宝珠状态  宝珠状态变化时
    [msgtype.defines.PushTribalArenaGemState] = EventCode.Push.OnPushTribalArenaGemState,
    --推送抽奖列表
    [msgtype.defines.PushWheelSurf] = EventCode.Push.PushWheelSurf,
    
    --小地图
    [msgtype.defines.PushRadar] = EventCode.Push.OnPushRadar,
   
    --国家
    --推送职位列表
    [msgtype.defines.PushCountryPosition] = EventCode.Push.OnPushCountryPosition,
    --推送官员列表
    [msgtype.defines.PushOfficials] = EventCode.Push.OnPushOfficials,
    --推送国民列表
    [msgtype.defines.PushCountryPlayers] = EventCode.Push.OnPushCountryPlayers,
    --推送禁言囚禁列表
    [msgtype.defines.PushJinYanAndImprion] = EventCode.Push.OnPushJinYanAndImprion,
    --投票
    [msgtype.defines.PushVoteWindow] = EventCode.Push.OnPushVoteWindow,
    
    
    --国战开启
    [msgtype.defines.PushGuoZhanState] = EventCode.Push.OnPushCountryWarState,
    -- add more
}

function PushDefine.Find(msgType)
    for k, v in pairs(PushEvents) do
        if k == msgType then
            return v
        end
    end
end

return PushDefine
