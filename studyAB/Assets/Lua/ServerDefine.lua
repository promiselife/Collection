--[["
	desc: 服务器配置定义
	author: yaoxin
	since: 2015-12-28
	copyright: xingchen
 "]]

local LangHelper = require "util.LangHelper"
local ServerDefine = {}

--A by Wenmin.Yu, 2017-07-10
--服务器状态
ServerDefine.Status = 
{
	Deleted 	= -1,  --已删除
	Stoped	= 0, --停服
	Maintenance = 1, --维护
	Available = 2, --顺畅
	Crowd = 3, 	   --拥挤
	Full= 4, 	   --火爆
	Test= 6, 	   --测试
}

ServerDefine.Commend = {
	None = 0,
	Commend = 1, --推荐
	New = 2,     --新服
}

ServerDefine.OuterUrl = {
	name = "外网",
	url = "https://static.ios.shyouai.com/",
}

ServerDefine.InnerUrl = {
	name = "内网",
	url = "http://mhtx.center.test.yhzbonline.com:8001/"
}

ServerDefine.Defines =
{	
	[1]={
		tabName = "主干区",
		logic={
			{id=1, ip="10.21.210.230", name="内测1-test1", port=8888, status=ServerDefine.Status.Full ,commend=ServerDefine.Commend.None},
			{id=2, ip="10.21.210.231", name="内测2-test2", port=8888, status=ServerDefine.Status.Crowd ,commend=ServerDefine.Commend.None},
			{id=14, ip="10.17.172.241", name="内测3-test3", port=8889, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			--{id=4, ip="10.21.210.201", name="内测4-test4", port=8888, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			{id=5, ip="10.21.212.75", name="内测5-dev", port=8888, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			-- {id=17, ip="10.17.172.33",  name="内测17-test17", port=11701, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			{id=18, ip="10.17.172.245",  name="内测18-test18", port=11801, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
		},
		login={ip="10.21.210.202", port=8101},
		center="http://10.21.210.202:8001/",
		custom="http://10.21.210.202:8002/",
		card="http://10.21.210.202:8003/",
		audit_version=0,
		audit_server=0,
	},
	[2]={
		tabName = "分支区",
		logic={
			{id=10, ip="10.21.210.236", name="分支稳1-test10", port=8889, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			{id=11, ip="10.21.210.236", name="分支测1-test11", port=11101, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			-- {id=12, ip="10.21.210.201", name="分支稳2-test12", port=8889, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			-- {id=13, ip="10.21.210.201", name="分支测2-test13", port=8890, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			{id=14, ip="10.17.172.241", name="分支调1-test14", port=8889, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			{id=15, ip="10.21.210.231", name="分支调2-test15", port=8889, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			-- {id=16, ip="10.17.172.33",  name="分支测3-test16", port=11601, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			{id=19, ip="10.17.172.245",  name="分支测4-test19", port=11901, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
		},
		login={ip="10.21.210.202", port=8101},
		center="http://10.21.210.202:8001/",
		custom="http://10.21.210.202:8002/",
		card="http://10.21.210.202:8003/",
		audit_version=0,
		audit_server=0,
	},
	[3]={
		tabName = "私服区",
		logic={
			{id=6, ip="10.21.210.200", name="内测6-yishun", port=10601, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			{id=7, ip="10.21.210.200", name="内测7-jieyufang", port=10701, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			{id=8, ip="10.21.210.200", name="内测8-fengjinli", port=10801, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			{id=9, ip="10.21.210.200", name="内测9-baibin", port=10901, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
			{id=25, ip="10.17.172.232", name="内测22-渊", port=11250, status=ServerDefine.Status.Available ,commend=ServerDefine.Commend.None},
		},
		login={ip="10.21.210.202", port=8101},
		center="http://10.21.210.202:8001/",
		custom="http://10.21.210.202:8002/",
		card="http://10.21.210.202:8003/",
		audit_version=0,
		audit_server=0,
	},
}

function ServerDefine.GetStatusText(status)
	if status==ServerDefine.Status.Maintenance then
		return LangHelper.GetText(LangHelper.LangDefines.ServerMaintenance)
	elseif status == ServerDefine.Status.Available then
		return LangHelper.GetText(LangHelper.LangDefines.ServerAvailable)
	elseif status == ServerDefine.Status.Crowd then
		return LangHelper.GetText(LangHelper.LangDefines.ServerCrowd)
	elseif status == ServerDefine.Status.Full then
		return LangHelper.GetText(LangHelper.LangDefines.ServerFull)
	elseif status == ServerDefine.Status.Test then
		return LangHelper.GetText(LangHelper.LangDefines.ServerTest)
	end

	return ""
end 

return ServerDefine