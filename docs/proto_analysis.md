# Protobuf 消息类型列表

## Msg.AbandonTask
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskID

## Msg.AbandonTaskAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         TaskID

## Msg.AbortTransportGoods
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.AbortTransportGoodsAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.AccountLogin
  String                         AccessToken
  MessageDescriptor              Descriptor
  String                         IP
  UInt32                         OsType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Sign
  Int64                          Time

## Msg.AccountLoginAck
  String                         Account
  RepeatedField`1                BaseLists
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  RepeatedField`1                SelfLists

## Msg.ActivateFuGui
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ActivateFuGuiAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  YS_SHOW                        Type

## Msg.ActivateYuanShen
  MessageDescriptor              Descriptor
  UInt64                         InstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Boolean                        Possessed

## Msg.ActivateYuanShenAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  UInt64                         InstID
  String                         Name
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  Boolean                        Possessed
  UInt32                         RetCode
  UInt32                         Score
  YS_SHOW                        Type

## Msg.ActiveMeridiansGraph
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  UInt32                         OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ActiveMeridiansGraphAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  UInt32                         OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.AddAndSendChat
  RepeatedField`1                Args
  CHAT_CHANNEL                   Channel
  String                         Content
  MessageDescriptor              Descriptor
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         RecverID
  UInt64                         SenderID
  String                         SenderName
  String                         Sign
  UInt32                         SpeakerID
  UInt32                         SysChatID

## Msg.AddAndSendChatAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         RecverID
  SendChatMessageAck             RetPb
  UInt64                         SenderID
  UInt32                         SpeakerID

## Msg.AddBuffAck
  MapField`2                     BuffMap
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  Boolean                        IsDelAll
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.AddCommissionedTask
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PublishID

## Msg.AddCommissionedTaskAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PublishID
  UInt32                         Remaining
  UInt32                         RetCode

## Msg.AddGenData
  Int64                          DelayTime
  MessageDescriptor              Descriptor
  UInt32                         DungeonGenID
  RepeatedField`1                GenIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.AdditParam
  MessageDescriptor              Descriptor
  UInt32                         ID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Up

## Msg.AddLegionMember
  UInt64                         ApproveID
  MessageDescriptor              Descriptor
  UInt64                         LegionID
  UInt32                         LegionLv
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID

## Msg.AddMailAck
  Mail                           AddMail
  UInt64                         DelMailInstID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.AddNotifyLegionAck
  MessageDescriptor              Descriptor
  UInt32                         NotifyType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  LegionRecord                   Record
  UInt32                         RetCode

## Msg.AddPackageCellNum
  UInt32                         AddCellNum
  MessageDescriptor              Descriptor
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.AddPackageCellNumAck
  MessageDescriptor              Descriptor
  UInt32                         NowCellNum
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.AddPackageItemAck
  MapField`2                     AddMap
  MessageDescriptor              Descriptor
  OPERATE_TYPE                   OptType
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.AddRelationshipAck
  PlayerBriefly                  Briefly
  MessageDescriptor              Descriptor
  GUAN_XI_TYPE                   GuanXiType
  Int64                          Intimacy
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.AddScreenCollideBoxAck
  MessageDescriptor              Descriptor
  Int64                          DestroyTime
  UInt64                         EntityID
  UInt32                         ItemID
  Int64                          ItemNum
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         RetCode

## Msg.AddScreenGateAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  UInt32                         GateID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         RetCode

## Msg.AddScreenGatherSpriteAck
  UInt32                         ConfID
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         ResCount
  UInt32                         RetCode

## Msg.AddScreenItemBoxAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  UInt32                         ItemID
  Int64                          ItemNum
  UInt64                         OwnerID
  Boolean                        OwnerPlayer
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          PickupTime
  PixelsPos                      Pos
  Int64                          RemoveTime
  UInt32                         RetCode

## Msg.AddScreenMonsterAck
  UInt32                         Anger
  COUNTRY_TYPE                   Country
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 Direction
  UInt32                         EffectSign
  UInt64                         EntityID
  Attrib                         HP
  Boolean                        IsCreate
  UInt32                         MonsterID
  UInt32                         MonsterLevel
  MessageParser`1                Parser
  RepeatedField`1                Pathway
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         RamblerSpeed
  Int64                          RemoveBodyTime
  UInt32                         RetCode
  Boolean                        SetFight
  UInt32                         Stage
  ENTITY_STATUS                  Status

## Msg.AddScreenNpcAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  UInt32                         NpcID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         RetCode

## Msg.AddScreenPlayerAck
  PlayerBase                     Base
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.AddScreenSkillSpriteAck
  PixelsPos                      CreatePos
  Int64                          CreateTime
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 Direction
  UInt64                         EntityID
  UInt64                         OwnerID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         RetCode
  UInt32                         SpriteID
  ENTITY_STATUS                  Status

## Msg.AddScreenStallsAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  PixelsPos                      Pos
  UInt32                         RetCode
  String                         Shout

## Msg.AddScreenStatueNpcAck
  TopRankPlayerInfo              Data
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  UInt32                         NpcID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  RANK_TYPE                      RankType
  UInt32                         RetCode

## Msg.AddScreenVehiclesAck
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 Direction
  UInt32                         EffectSign
  UInt64                         EntityID
  Attrib                         HP
  UInt64                         OwnerID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         RamblerSpeed
  UInt32                         RetCode
  Boolean                        SetFight
  MapField`2                     SkillMap
  ENTITY_STATUS                  Status
  UInt32                         VehiclesID
  UInt32                         VehiclesLevel

## Msg.AddYsBuildSkill
  UInt32                         BookItemID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         YsInstID

## Msg.AddYsBuildSkillAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SkillID
  UInt64                         YsInstID

## Msg.AddYsFuse
  ATTRIBUTE                      Attrib
  MapField`2                     CostHorcrux
  UInt64                         CostYsInstID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Select
  UInt64                         YsInstID

## Msg.AddYsFuseAck
  ATTRIBUTE                      Attrib
  UInt64                         CostYsInstID
  MessageDescriptor              Descriptor
  UInt32                         Energy
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Select
  UInt32                         Value
  UInt64                         YsInstID

## Msg.AddYsFuseClear
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Select
  UInt64                         YsInstID

## Msg.AddYsFuseClearAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Select
  UInt64                         YsInstID

## Msg.AddYsGrowthValue
  ATTRIBUTE                      Attrib
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         UseItemID
  UInt64                         YsInstID

## Msg.AddYsGrowthValueAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Boolean                        Success
  ItemData                       YsData
  UInt64                         YsInstID

## Msg.AddYsRefreshSixiang
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         YsInstID

## Msg.AddYsRefreshSixiangAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  ATTRIBUTE                      SiXiangType
  UInt64                         YsInstID

## Msg.AddYsRefreshSkill
  MessageDescriptor              Descriptor
  MapField`2                     LockMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         YsInstID

## Msg.AddYsRefreshSkillAck
  MessageDescriptor              Descriptor
  UInt32                         LockLucky
  UInt32                         LuckySkillID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SpecialID
  UInt32                         UnlockLucky
  UInt64                         YsInstID

## Msg.AddYsUpSkill
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SkillID
  UInt64                         YsInstID

## Msg.AddYsUpSkillAck
  MessageDescriptor              Descriptor
  UInt32                         NewSkillID
  UInt32                         OldSkillID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         YsInstID

## Msg.AlleviateNode
  UInt32                         AlleviateCount
  MessageDescriptor              Descriptor
  UInt32                         GetbackDay
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.AllocateLine
  MessageDescriptor              Descriptor
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         Token

## Msg.AllocateLineAck
  MessageDescriptor              Descriptor
  ServerHost                     Host
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RegionID
  UInt32                         RetCode

## Msg.AppearanceData
  UInt32                         BattleScore
  MessageDescriptor              Descriptor
  Int64                          DestroyTime
  Boolean                        IsWear
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.AppearanceWearStatusAck
  MapField`2                     ChangedData
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ApplyAddRelationship
  MessageDescriptor              Descriptor
  GUAN_XI_TYPE                   GuanXiType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID
  String                         TargetName

## Msg.ApplyAddRelationshipAck
  ApplyRelationshipData          ApplyData
  MessageDescriptor              Descriptor
  GUAN_XI_TYPE                   GuanXiType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ApplyAddTeam
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID
  UInt64                         TeamId

## Msg.ApplyAddTeamAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ApplyAddTeamNtfAck
  PlayerBriefly                  Briefly
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ApplyLegion
  MessageDescriptor              Descriptor
  UInt64                         LegionID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ApplyLegionAck
  LegionBase                     BaseInfo
  MessageDescriptor              Descriptor
  UInt64                         LegionID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ApplyLegionCountAck
  UInt32                         ApplyCount
  MessageDescriptor              Descriptor
  UInt64                         LegionID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ApplyRelationshipData
  PlayerBriefly                  Briefly
  MessageDescriptor              Descriptor
  Boolean                        IsRead
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          Time

## Msg.ApplyTrade
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.ApplyTradeAck
  PlayerBriefly                  Briefly
  MessageDescriptor              Descriptor
  Int64                          LimitTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  String                         Sign

## Msg.AppraisalYuanShen
  MessageDescriptor              Descriptor
  UInt64                         InstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.AppraisalYuanShenAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.AppraiseAndRefiningItem
  MessageDescriptor              Descriptor
  UInt32                         ItemID
  OPERATE_TYPE                   Opt
  Int64                          OutputNum
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.AppraiseAndRefiningItemAck
  MapField`2                     AddMap
  MessageDescriptor              Descriptor
  OPERATE_TYPE                   Opt
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ApproveApplyLegion
  Boolean                        Agree
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.ApproveApplyLegionAck
  Boolean                        Agree
  MessageDescriptor              Descriptor
  UInt64                         LegionID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID

## Msg.ArgParam
  MessageDescriptor              Descriptor
  UInt32                         EquipScore
  UInt32                         ItemID
  UInt64                         ItemInstID
  Int64                          ItemNum
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt64                         TeamID
  UInt64                         TeamLeaderID
  String                         Text
  ARG_TYPE                       Type

## Msg.Attrib
  UInt32                         Curr
  MessageDescriptor              Descriptor
  UInt32                         Max
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.AttribParam
  ATTRIBUTE                      Attrib
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int32                          Value

## Msg.BatchGetPlayerBase
  MessageDescriptor              Descriptor
  MapField`2                     IdMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  OPERATE_TYPE                   Type

## Msg.BatchGetPlayerBaseAck
  RepeatedField`1                Bases
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  OPERATE_TYPE                   Type

## Msg.BattleAwardClam
  UInt32                         AwardType
  MessageDescriptor              Descriptor
  UInt32                         FightType
  UInt32                         Index
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BattleAwardClamAck
  UInt32                         AwardType
  MessageDescriptor              Descriptor
  UInt32                         FightType
  UInt32                         Index
  BattleRewardInfo               Info
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.BattleAwardDetail
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BattleAwardDetailAck
  UInt32                         CampCount
  COUNTRY_TYPE                   CampCountry
  UInt32                         CountryBattleJoinAwardState
  MessageDescriptor              Descriptor
  UInt32                         LegionCount
  BattleRewardInfo               LegionInfo
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  BattleRewardInfo               PVPInfo
  UInt32                         RetCode
  BattleRewardInfo               TeamInfo
  COUNTRY_TYPE                   WinCountry

## Msg.BattleFinishAck
  MessageDescriptor              Descriptor
  UInt32                         FightType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.BattlePvpDetail
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BattlePvpDetailAck
  UInt32                         DeadCount
  MessageDescriptor              Descriptor
  UInt32                         KillCount
  UInt32                         KillScore
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.BattlePvpFight
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BattlePvpFightAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.BattleRewardInfo
  UInt32                         BattleJoinAwardState
  UInt32                         BattleScore
  UInt64                         BattleScoreAwardSign
  UInt32                         BattleWinAwardState
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     RewardLimit

## Msg.BattleTeamDetail
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BattleTeamDetailAck
  UInt32                         DeadCount
  MessageDescriptor              Descriptor
  UInt32                         KillCount
  UInt32                         KillScore
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         TeamKill
  UInt32                         TeamScore

## Msg.BattleTeamFight
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BattleTeamFightAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.BeiMangShanDungeon
  UInt32                         BmsConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BindInviteCode
  MessageDescriptor              Descriptor
  String                         InviteCode
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Token

## Msg.BindInviteCodeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.BindItem
  ChooseOne                      ChooseInst
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         UseItemID

## Msg.BindItemAck
  ChooseOne                      ChooseInst
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.BindSecurityInfo
  MessageDescriptor              Descriptor
  String                         Email
  String                         IDNumber
  String                         Mobile
  String                         Name
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         SecurityCode
  String                         Token

## Msg.BindSecurityInfoAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.BlacklistData
  PlayerBriefly                  Briefly
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          Time

## Msg.BmsNextRoundAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Round

## Msg.BmsSettlementNode
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PlayerBossHp
  UInt32                         PlayerKill
  String                         PlayerName

## Msg.BuffNode
  UInt64                         AdditiveID
  MessageDescriptor              Descriptor
  Int64                          Duration
  UInt32                         EffectID
  Int64                          Elapse
  OPERATE_TYPE                   OptType
  UInt32                         OverlapCount
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SkillID
  Int64                          Value

## Msg.BuffParam
  UInt64                         AdditiveID
  BUFF_KIND                      BuffKind
  BUFF_TYPE                      BuffType
  Boolean                        CanDispeled
  MessageDescriptor              Descriptor
  Int64                          Duration
  UInt32                         EffectID
  Int64                          Elapse
  UInt32                         GroupID
  UInt64                         ID
  UInt32                         Level
  MAP_TYPE                       NotMapType
  OPERATE_TYPE                   OptType
  UInt32                         OverlapCount
  UInt64                         OwnerID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PhyleticID
  SKILL_QUALITY_TYPE             Quality
  BUFF_RELATIONSHIP              RelationGroup
  BUFF_RELATIONSHIP              Relationship
  UInt32                         SaveSign
  UInt32                         SkillID
  Int64                          Timeout
  UInt32                         TimeType
  Int64                          Value

## Msg.BuyConsignmentItem
  UInt32                         BuyNum
  MessageDescriptor              Descriptor
  UInt64                         InstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BuyConsignmentItemAck
  Int64                          AfterTax
  UInt64                         BuyerID
  String                         BuyerName
  MessageDescriptor              Descriptor
  ItemData                       ItemData
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          Tax

## Msg.BuyMoneyManagement
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BuyMoneyManagementAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.BuySellSgd
  MessageDescriptor              Descriptor
  UInt64                         OrderID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BuySellSgdAck
  UInt32                         Amount
  MessageDescriptor              Descriptor
  UInt64                         OrderID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.BuyShopGoods
  MapField`2                     BuyMap
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         ShopID

## Msg.BuyShopGoodsAck
  MapField`2                     CountMap
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         ShopID

## Msg.BuyStallsInfo
  UInt32                         BuyNum
  MessageDescriptor              Descriptor
  UInt64                         InstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BuyStallsItem
  RepeatedField`1                BuyLists
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         StallsInstID

## Msg.BuyStallsItemAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.BuyVipBigPack
  UInt32                         BuyType
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.BuyVipBigPackAck
  UInt32                         BuyType
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         RetCode
  RepeatedField`1                Rewards

## Msg.CallMembersTeam
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerId

## Msg.CallMembersTeamAck
  MessageDescriptor              Descriptor
  Int64                          LimitTime
  UInt32                         LineID
  UInt32                         MapID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         RetCode
  String                         Sign
  UInt64                         SummonerID
  String                         SummonerName

## Msg.CancelDeletePlayer
  String                         AccessToken
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         Sign
  Int64                          Time

## Msg.CancelDeletePlayerAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.CancelTrade
  MessageDescriptor              Descriptor
  Boolean                        IsLock
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.CancelTradeAck
  MessageDescriptor              Descriptor
  Boolean                        IsLock
  Boolean                        IsSelf
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         PlayerName
  UInt32                         RetCode

## Msg.CBScoreInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RandCount
  UInt32                         TotalScore

## Msg.CBStatueInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     StatueMap

## Msg.ChallengeDungeon
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ChangeAreaParam
  UInt32                         AreaID
  MessageDescriptor              Descriptor
  UInt32                         Limit
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Probability

## Msg.ChangeBlacklist
  MessageDescriptor              Descriptor
  Boolean                        IsAdd
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.ChangeBlacklistAck
  MessageDescriptor              Descriptor
  Boolean                        IsAdd
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID
  String                         TargetName

## Msg.ChangeCountry
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  COUNTRY_TYPE                   SetNew

## Msg.ChangeCountryAck
  MessageDescriptor              Descriptor
  COUNTRY_TYPE                   LastCountry
  COUNTRY_TYPE                   NewCountry
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.ChangeHpCurrentAck
  UInt64                         AttackID
  ATTRIBUTE                      Attrute
  UInt32                         DamageID
  Boolean                        DefenseCooperate
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  Int32                          Final
  OPERATE_TYPE                   OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  SHOW_TYPE                      Show
  Int32                          ShowValue
  UInt32                         SkillID

## Msg.ChangeYsAddPoint
  MessageDescriptor              Descriptor
  AttribParam                    Param
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         YsInstID

## Msg.ChangeYsAddPointAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  ItemData                       YsData

## Msg.ChangeYsName
  MessageDescriptor              Descriptor
  String                         NewName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         YsInstID

## Msg.ChangeYsNameAck
  MessageDescriptor              Descriptor
  String                         NewName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  UInt64                         YsInstID

## Msg.ChangeYsResetPoint
  ATTRIBUTE                      Attrib
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         YsInstID

## Msg.ChangeYsResetPointAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  ItemData                       YsData

## Msg.ChangeYsUpGrade
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  Boolean                        KeepFuse
  Boolean                        KeepLv
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     SkillIDs
  UInt64                         YsInstID

## Msg.ChangeYsUpGradeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  ItemData                       YsData

## Msg.ChatNode
  RepeatedField`1                Args
  UInt32                         ChatNum
  String                         Content
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  Int64                          SendTime
  String                         Sign
  UInt32                         SysChatID

## Msg.ChatTransferTo
  MessageDescriptor              Descriptor
  UInt32                         MapID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  String                         Sign
  Int64                          Time

## Msg.ChatTransferToAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.CheckXiaoLianQuestion
  UInt32                         Answer
  MessageDescriptor              Descriptor
  Boolean                        IsUseResetItem
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         QuestionID

## Msg.CheckXiaoLianQuestionAck
  UInt32                         Answer
  RepeatedField`1                Award
  MessageDescriptor              Descriptor
  Boolean                        IsLastQuestion
  Boolean                        IsReset
  Boolean                        IsRight
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         QuestionID
  Question                       QuestionParam
  UInt32                         RetCode
  UInt32                         RightAnswer

## Msg.ChooseOne
  Int64                          ChooseNum
  MessageDescriptor              Descriptor
  UInt64                         InstID
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ChoosePackage
  MapField`2                     ChooseMap
  MessageDescriptor              Descriptor
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ClaimCycleSignIn
  UInt32                         ConfigID
  UInt32                         CycleID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ClaimCycleSignInAck
  UInt32                         ConfigID
  UInt32                         CycleID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  RepeatedField`1                Rewards

## Msg.ClaimLegionWelfareReward
  UInt32                         ClaimStages
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ClaimLegionWelfareRewardAck
  UInt32                         ClaimStages
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ClaimMoneyManagement
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ClaimMoneyManagementAck
  UInt32                         ClaimNum
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  Boolean                        FirstClaim
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Remaining
  UInt32                         RetCode
  UInt32                         YearDay

## Msg.ClaimMonthSignIn
  MessageDescriptor              Descriptor
  UInt32                         Month
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ClaimMonthSignInAck
  UInt32                         ClaimCount
  MessageDescriptor              Descriptor
  UInt32                         Month
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     Rewards

## Msg.ClaimNewYearActivityReward
  MessageDescriptor              Descriptor
  Boolean                        IsGetClaimSign
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ClaimNewYearActivityRewardAck
  UInt32                         ClaimCount
  Boolean                        ClaimSign
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  RepeatedField`1                RewardLists

## Msg.ClaimRechargeReward
  UInt32                         ClaimAmount
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         ResetType

## Msg.ClaimRechargeRewardAck
  UInt32                         ClaimAmount
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         ResetType
  UInt32                         RetCode
  RepeatedField`1                Rewards

## Msg.ClaimSanGuoDianConsumeReward
  UInt32                         ClaimAmount
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         ResetType

## Msg.ClaimSanGuoDianConsumeRewardAck
  UInt32                         ClaimAmount
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         ResetType
  UInt32                         RetCode
  RepeatedField`1                Rewards

## Msg.ClaimSealStone
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ClaimSealStoneAck
  MessageDescriptor              Descriptor
  UInt32                         LastConfID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ClaimShopScoreConsumeReward
  UInt32                         ClaimAmount
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ClaimShopScoreConsumeRewardAck
  UInt32                         ClaimAmount
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         RetCode
  RepeatedField`1                Rewards

## Msg.ClaimTaskAward
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskID

## Msg.ClaimTaskAwardAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ClaimVipReward
  MessageDescriptor              Descriptor
  Boolean                        IsSVip
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ClaimVipRewardAck
  MessageDescriptor              Descriptor
  Boolean                        IsSVip
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ClaimVitality
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Boolean                        UseVIP

## Msg.ClaimVitalityAck
  UInt32                         ClaimCount
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ClaimVitalityGrade
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ClaimVitalityGradeAck
  UInt32                         ClaimGrade
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ClaimWelfare
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ClaimWelfareAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ClearLegionID
  MessageDescriptor              Descriptor
  UInt64                         LegionID
  OPERATE_TYPE                   Opt
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.CloseService
  UInt32                         CloseCode
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         Sign
  Int64                          Time

## Msg.CloseServiceAck
  ERROR_CODE                     CloseCode
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.CollectCollideBox
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.CollectCollideBoxAck
  MessageDescriptor              Descriptor
  Int64                          NextCollideTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.CommissionedCompose
  UInt32                         ComposeCount
  MessageDescriptor              Descriptor
  UInt32                         FormulaIdx
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.CommissionedComposeAck
  UInt32                         ComposeCount
  MessageDescriptor              Descriptor
  UInt32                         FormulaIdx
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.CommissionedTask
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         Remaining
  UInt32                         TaskID

## Msg.ComposeEquipment
  UInt32                         ComposeCount
  UInt64                         DaZaoJuanInsID
  MessageDescriptor              Descriptor
  UInt32                         FormulaID
  UInt64                         JingYuID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         ZhuoKongYuID

## Msg.ComposeEquipmentAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ComposeItem
  UInt32                         ComposeCount
  MessageDescriptor              Descriptor
  UInt32                         FormulaID
  UInt32                         MaterialCount
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ComposeItemAck
  UInt32                         ComposeCount
  MessageDescriptor              Descriptor
  UInt32                         FormulaID
  UInt32                         MaterialCount
  RepeatedField`1                OutProps
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ConfirmRebirth
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         UseImpunityItem

## Msg.ConfirmRebirthAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RebirthMapID
  UInt32                         RetCode
  UInt32                         UseImpunityItem

## Msg.ConfirmTrade
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Sign
  Int64                          Time

## Msg.ConfirmTradeAck
  MessageDescriptor              Descriptor
  Boolean                        IsSucceed
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.ConsignmentClassify
  MessageDescriptor              Descriptor
  UInt32                         ItemID
  Int64                          MinPrice
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ConsignmentInfo
  ItemData                       Data
  MessageDescriptor              Descriptor
  Int64                          EndTime
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          Price
  UInt32                         Remaining
  UInt32                         SalesVolume
  UInt64                         SellerID

## Msg.ConsignmentItem
  ItemData                       Data
  MessageDescriptor              Descriptor
  Int64                          EndTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          Price
  UInt64                         SellerID
  String                         SellerName

## Msg.ConsignmentRecord
  UInt64                         BuyerID
  String                         BuyerName
  Int64                          BuyPrice
  Int64                          BuyTime
  MessageDescriptor              Descriptor
  ItemData                       ItemData
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ConsignmentSort
  MessageDescriptor              Descriptor
  Int64                          EndTime
  UInt64                         InstID
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          Price
  UInt64                         SellerID

## Msg.ConvertSealStone
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ConvertSealStoneAck
  UInt32                         ConfigID
  UInt32                         ConvertNum
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.CostSanGuoDianRecord
  MapField`2                     BuyParam
  MapField`2                     BuyProp
  Int64                          BuyTime
  MapField`2                     CostMap
  MessageDescriptor              Descriptor
  UInt32                         MailID
  UInt32                         OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     ResetMap
  UInt32                         SanGuoDian

## Msg.CountryBattleApply
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.CountryBattleApplyAck
  UInt32                         CountryFightSign
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.CountryBattleAwardClam
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.CountryBattleAwardClamAck
  UInt32                         CountryBattleJoinAwardState
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.CountryBattleChangeCountryAck
  UInt32                         AreaID
  MessageDescriptor              Descriptor
  COUNTRY_TYPE                   LastCountry
  COUNTRY_TYPE                   NowCountry
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         StatueID

## Msg.CountryBattleDetail
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.CountryBattleDetailAck
  MapField`2                     AreaMap
  COUNTRY_TYPE                   CampCountry
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     ScoreMap

## Msg.CountryBattleFight
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.CountryBattleFightAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.CountryBattleUpdateScoreAck
  UInt32                         AddScore
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.CountryFightBuyBuff
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.CountryFightBuyBuffAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.CountryFightResultAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     ScoreMap
  COUNTRY_TYPE                   WinCountry

## Msg.CreateLegion
  MessageDescriptor              Descriptor
  String                         LegionName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.CreateLegionAck
  LegionBase                     BaseInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.CreatePayOrder
  UInt32                         ChannelID
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  PAY_FUNC_TYPE                  PayFuncType
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.CreatePayOrderAck
  Int64                          CdTime
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  String                         OrderData
  String                         OrderID
  MessageParser`1                Parser
  PAY_FUNC_TYPE                  PayFuncType
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.CreatePlayer
  String                         AccessToken
  COUNTRY_TYPE                   Country
  MessageDescriptor              Descriptor
  GENDER_TYPE                    Gender
  UInt32                         Hairstyle
  UInt32                         HairstyleColor
  JOB_TYPE                       Job
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         PlayerName
  String                         Sign
  Int64                          Time

## Msg.CreatePlayerAck
  String                         Account
  PlayerBase                     BaseInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  PlayerSelf                     SelfInfo

## Msg.CreateTeamDungeon
  UInt32                         ConfigId
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  TARGET_CONTENT_TYPE            Type

## Msg.CreateTeamDungeonAck
  UInt32                         ConfigId
  MessageDescriptor              Descriptor
  Int64                          EndTIme
  MapField`2                     ErrMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  TARGET_CONTENT_TYPE            Type

## Msg.CreatTeam
  MessageDescriptor              Descriptor
  LimitValue                     Lv
  UInt32                         MapId
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Text
  TARGET_CONTENT_TYPE            Type

## Msg.CreatTeamAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  TeamData                       TeamData

## Msg.CycleSignInValue
  MapField`2                     ConfigID
  UInt32                         CurrValue
  UInt32                         CycleID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          RemoveTime
  UInt32                         Replenishment

## Msg.DailySignIn
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.DailySignInAck
  UInt32                         CycleSignValue
  MessageDescriptor              Descriptor
  SignInNode                     MonthData
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  RepeatedField`1                Rewards

## Msg.DeathNotifyAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  ENTITY_TYPE                    EntityType
  String                         Name
  OPERATE_TYPE                   Opt
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          SpotCdTime
  UInt32                         SpotRebirth

## Msg.DecomposeItem
  RepeatedField`1                ChooseList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.DecomposeItemAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DefaultAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DelBuffAck
  UInt64                         BuffID
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DeleteAllReadMail
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.DeleteAllReadMailAck
  MessageDescriptor              Descriptor
  RepeatedField`1                MailInstIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DeleteMail
  MessageDescriptor              Descriptor
  UInt64                         MailInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.DeleteMailAck
  MessageDescriptor              Descriptor
  UInt64                         MailInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DeletePlayer
  String                         AccessToken
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         Sign
  Int64                          Time

## Msg.DeletePlayerAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  Int64                          RemoveTime
  UInt32                         RetCode

## Msg.DeletePrivateChat
  MessageDescriptor              Descriptor
  UInt64                         OtherID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID

## Msg.DeletePrivateChatAck
  MessageDescriptor              Descriptor
  UInt64                         OtherID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DeliverProficiency
  MessageDescriptor              Descriptor
  ESSENCE_TYPE                   EssenceType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.DeliverProficiencyAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DelRelationship
  MessageDescriptor              Descriptor
  GUAN_XI_TYPE                   GuanXiType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.DelRelationshipAck
  MessageDescriptor              Descriptor
  GUAN_XI_TYPE                   GuanXiType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID

## Msg.DelScreenAck
  MessageDescriptor              Descriptor
  RepeatedField`1                EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PickupID
  UInt32                         RetCode

## Msg.DelScreenChat
  MessageDescriptor              Descriptor
  UInt64                         InstMapID
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.DestroyItem
  MessageDescriptor              Descriptor
  Boolean                        IsDestroy
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.DestroyItemAck
  MessageDescriptor              Descriptor
  MapField`2                     DestroyMap
  Boolean                        IsDestroy
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DownConsignmentItem
  MessageDescriptor              Descriptor
  UInt64                         InstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.DownConsignmentItemAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DownSellSgd
  MessageDescriptor              Descriptor
  UInt64                         OrderID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.DownSellSgdAck
  UInt32                         Amount
  MessageDescriptor              Descriptor
  UInt64                         OrderID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DownStallsItem
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.DownStallsItemAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DungeonBmsUpdateAck
  UInt32                         BmsConfigID
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         TotalBossHp
  UInt32                         TotalKill

## Msg.DungeonClslUpdateAck
  UInt32                         Bount
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  Int64                          NextBountTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.DungeonHjqfyInfoAck
  FinishCondition                Condition
  MessageDescriptor              Descriptor
  Int64                          DestroyTime
  UInt32                         DungeonID
  UInt64                         DungeonInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.EffectTimeUpdateAck
  Int32                          CurrFatigue
  Int32                          DailyFreeFatigue
  MessageDescriptor              Descriptor
  Int64                          DoubleRemainingTime
  BUTTON_STATUS                  DoubleStatus
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          QxxlRemainingTime
  BUTTON_STATUS                  QxxlStatus
  UInt32                         RetCode

## Msg.EmbedEquip
  MessageDescriptor              Descriptor
  MapField`2                     EmbedMap
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.EmbedEquipAck
  MessageDescriptor              Descriptor
  ItemData                       EquipData
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.EnhanceEquip
  MessageDescriptor              Descriptor
  Boolean                        IsUseSpecialItem
  UInt32                         JewelItemID
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.EnhanceEquipAck
  MessageDescriptor              Descriptor
  ItemData                       EquipData
  Boolean                        IsSucceed
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.EnhanceTransferEquip
  MessageDescriptor              Descriptor
  ChooseOne                      InEquip
  ChooseOne                      OutEquip
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.EnhanceTransferEquipAck
  MessageDescriptor              Descriptor
  ChooseOne                      InEquip
  UInt32                         NewInBattleScore
  UInt32                         NewInLv
  UInt32                         NewOutBattleScore
  UInt32                         NewOutLv
  ChooseOne                      OutEquip
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.EnterMap
  String                         AccessToken
  MessageDescriptor              Descriptor
  UInt32                         EnterType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         Sign
  Int64                          Time

## Msg.EnterMapAck
  PlayerBase                     BaseInfo
  MessageDescriptor              Descriptor
  UInt32                         EnterType
  Int64                          InitTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  PlayerSelf                     SelfInfo

## Msg.EnterMapFinishNtfAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.EnterOrLeaveVehicles
  MessageDescriptor              Descriptor
  Boolean                        IsEnter
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         VehiclesInstID

## Msg.EnterOrLeaveVehiclesAck
  MessageDescriptor              Descriptor
  Boolean                        IsEnter
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  UInt64                         VehiclesInstID

## Msg.EpithetNode
  UInt32                         CollectSign
  MessageDescriptor              Descriptor
  UInt32                         EffectSign
  Int64                          LimitTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         ReadSign

## Msg.EquipAddProficiency
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  ChooseOne                      SetEquip
  UInt32                         UseItemID

## Msg.EquipAddProficiencyAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Proficiency1
  UInt32                         Proficiency2
  UInt32                         RetCode
  ChooseOne                      SetEquip

## Msg.EquipData
  RepeatedField`1                AdditID
  RepeatedField`1                BaseEntryID
  RepeatedField`1                BaseID
  UInt32                         BattleScore
  MessageDescriptor              Descriptor
  Attrib                         Durability
  UInt32                         EnhanceLv
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PrefixScore
  UInt32                         Proficiency1
  UInt32                         Proficiency2
  UInt32                         RemakeEntryID
  UInt32                         RemakeEntryLv
  RepeatedField`1                RemakeID
  UInt32                         RemakeResidual
  UInt32                         RemakeSucce
  UInt32                         SiXiangLv
  ATTRIBUTE                      SiXiangType
  RepeatedField`1                SlotID

## Msg.EquipMakeLvUpdateAck
  UInt32                         CurrLevel
  MessageDescriptor              Descriptor
  ESSENCE_TYPE                   EssenceType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.EquipProficiencyNode
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Proficiency1
  UInt32                         Proficiency2

## Msg.EquipRepairChange
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetEquipInstID
  PACK_TYPE                      TargetPackType
  UInt64                         UseItemInstID

## Msg.EquipRepairChangeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetEquipInstID
  PACK_TYPE                      TargetPackType

## Msg.EquipUpdateDurabilityAck
  MessageDescriptor              Descriptor
  Attrib                         Durability
  UInt64                         InstID
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ExchangeItem
  MessageDescriptor              Descriptor
  Int64                          ExchagneNum
  UInt32                         FormulaID
  UInt64                         InstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ExchangeItemAck
  MessageDescriptor              Descriptor
  Int64                          ExchagneNum
  UInt32                         FormulaID
  UInt64                         InstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ExchangeOfflineExp
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ExchangeOfflineExpAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         RetCode

## Msg.ExitDungeon
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ExitDungeonAck
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ExpFatigueData
  Boolean                        CanRewardFreeFatigue
  Int32                          DailyFreeExpFatigue
  MessageDescriptor              Descriptor
  Int64                          DoublePauseCanClickTime
  BUTTON_STATUS                  DoubleStatus
  Int64                          DoubleTime
  Int32                          ExpFatigue
  Int32                          ExpFatigueCostWeekly
  Int64                          NextWeekFatigueResetTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          QixinxieliTime
  Int64                          QxxlPauseCanClickTime
  BUTTON_STATUS                  QxxlStatus

## Msg.ExtendNode
  String                         Account
  UInt32                         ChannelID
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  UInt32                         PayFuncType
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         RegionID

## Msg.FatigueUpdateAck
  Int32                          CurrFatigue
  Int32                          DailyFreeFatigue
  MessageDescriptor              Descriptor
  Int32                          ExpFatigueCostWeekly
  OPERATE_TYPE                   OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.FinishCondition
  RepeatedField`1                CountList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  TASK_STATUS                    Status

## Msg.FinishTransportGoodsInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.FinishTransportGoodsInfoAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.FlushRank
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RankType

## Msg.ForwardLegionMsg
  MessageDescriptor              Descriptor
  RepeatedField`1                ExcludeID
  UInt64                         LegionID
  UInt32                         MsgID
  ByteString                     NotifyData
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ForwardMsg
  MessageDescriptor              Descriptor
  Int32                          ForwardMsg_
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ForwardMsgAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  Int32                          ForwardMsg
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ForwardMsgNotif
  MessageDescriptor              Descriptor
  UInt32                         MsgID
  ByteString                     NotifyData
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                Targets

## Msg.ForwardNewMail
  UInt64                         DelMailInstID
  MessageDescriptor              Descriptor
  Mail                           MailData
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID

## Msg.FriendData
  PlayerBriefly                  Briefly
  MessageDescriptor              Descriptor
  Int64                          Intimacy
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.FromServer
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         ServerIP
  String                         ServerName

## Msg.FuZouResetAttrib
  MessageDescriptor              Descriptor
  MapField`2                     LockMap
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.FuZouResetAttribAck
  RepeatedField`1                AdditID
  UInt32                         BattleScore
  MessageDescriptor              Descriptor
  MapField`2                     LockMap
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.FuZouUpStar
  MessageDescriptor              Descriptor
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.FuZouUpStarAck
  UInt32                         BattleScore
  MessageDescriptor              Descriptor
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         UpStarID

## Msg.GetAllAttribute
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID

## Msg.GetAllAttributeAck
  MapField`2                     AttribMap
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.GetAllAwardMail
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetAllAwardMailAck
  MessageDescriptor              Descriptor
  Int64                          Expire
  RepeatedField`1                MailInstIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetAllLine
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         Token

## Msg.GetAllLineAck
  UInt32                         CurrentLineID
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RegionID
  UInt32                         RetCode

## Msg.GetAllPlayer
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Token

## Msg.GetAllPlayerAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetAllRanking
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetAllRankingAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     Ranking
  UInt32                         RetCode

## Msg.GetAllRegion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Token

## Msg.GetAllRegionAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetApplyListLegion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetApplyListLegionAck
  MapField`2                     ApplyMap
  Boolean                        AutoApprove
  MessageDescriptor              Descriptor
  String                         Manifesto
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetApplyRelationshipList
  MessageDescriptor              Descriptor
  Boolean                        IsReadAll
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetApplyRelationshipListAck
  RepeatedField`1                ApplyList
  MessageDescriptor              Descriptor
  Boolean                        IsReadAll
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetAutoItemSetting
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetAutoItemSettingAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  String                         SettingData

## Msg.GetAutoSkillSetting
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetAutoSkillSettingAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SettingMap

## Msg.GetAwardMail
  MessageDescriptor              Descriptor
  UInt64                         MailInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetAwardMailAck
  MessageDescriptor              Descriptor
  Int64                          Expire
  UInt64                         MailInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetBeiMangShanInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetBeiMangShanInfoAck
  MapField`2                     BmsMap
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetBindReward
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Token

## Msg.GetBindRewardAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetBlacklist
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetBlacklistAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetChangeMemberLegion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetChangeMemberLegionAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetChatList
  MessageDescriptor              Descriptor
  UInt32                         LineID
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID

## Msg.GetChatListAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetCommissionedTask
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetCommissionedTaskAck
  UInt32                         Count
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     TaskMap

## Msg.GetConsignmentInfoList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetConsignmentInfoListAck
  MapField`2                     DataMap
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetConsignmentItemList
  Boolean                        AscOrder
  MessageDescriptor              Descriptor
  UInt32                         ItemID
  UInt32                         Page
  UInt32                         PageSize
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetConsignmentItemListAck
  Boolean                        AscOrder
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  Int64                          LowestPrice
  UInt32                         Page
  UInt32                         PageSize
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Total

## Msg.GetConsignmentRecordList
  MessageDescriptor              Descriptor
  UInt32                         Page
  UInt32                         PageSize
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetConsignmentRecordListAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  UInt32                         Page
  UInt32                         PageSize
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Total

## Msg.GetDailyDoubleExpTime
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetDailyDoubleExpTimeAck
  MessageDescriptor              Descriptor
  Int64                          DoubleRemainingTime
  BUTTON_STATUS                  DoubleStatus
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetDeathInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetDeathInfoAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          SpotCdTime
  UInt32                         SpotRebirth

## Msg.GetDungeonInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetDungeonInfoAck
  MapField`2                     CountMap
  MessageDescriptor              Descriptor
  MapField`2                     FinalMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetEpithet
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetEpithetAck
  MessageDescriptor              Descriptor
  MapField`2                     EpithetMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetEquipMakeLv
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetEquipMakeLvAck
  MessageDescriptor              Descriptor
  MapField`2                     EssenceLvMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetEventNotifyLegion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetEventNotifyLegionAck
  MessageDescriptor              Descriptor
  Int64                          LastEventTime
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetFuncPortSetting
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetFuncPortSettingAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  String                         SettingData

## Msg.GetGaiXiaXueYiInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetGaiXiaXueYiInfoAck
  MessageDescriptor              Descriptor
  Int64                          JinXiuRemaining
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetGiveGiftList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetGiveGiftListAck
  MessageDescriptor              Descriptor
  MapField`2                     GiftID
  UInt32                         LoginDays
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int32                          Remaining
  UInt32                         RetCode

## Msg.GetGoodsList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         ShopID

## Msg.GetGoodsListAck
  MessageDescriptor              Descriptor
  MapField`2                     GoodsMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         ShopID

## Msg.GetGuideReward
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetGuideRewardAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  RepeatedField`1                Rewards

## Msg.GetHyperlinkDetails
  MessageDescriptor              Descriptor
  UInt64                         InstID
  HYPERLINK_TYPE                 LinkType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetHyperlinkDetailsAck
  MessageDescriptor              Descriptor
  DetailsOneofCase               DetailsCase
  ItemData                       Item
  HYPERLINK_TYPE                 LinkType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  HyperlinkPlayer                Player
  UInt32                         RetCode

## Msg.GetItemSetting
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetItemSettingAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  String                         SettingData

## Msg.GetItemUseCount
  String                         ClientParam
  MessageDescriptor              Descriptor
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetItemUseCountAck
  String                         ClientParam
  MessageDescriptor              Descriptor
  UInt32                         ItemID
  Int64                          NextResetTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         UseCount

## Msg.GetLegionBase
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetLegionBaseAck
  LegionBase                     BaseInfo
  MessageDescriptor              Descriptor
  Boolean                        IsLogin
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetLegionGatherInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetLegionGatherInfoAck
  UInt32                         BeRobCount
  MessageDescriptor              Descriptor
  UInt32                         GatherCount
  UInt32                         GatherCurrent
  UInt32                         KillCount
  MessageParser`1                Parser
  String                         PartOpenTime
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         RobCount

## Msg.GetLegionList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         SearchName

## Msg.GetLegionListAck
  MapField`2                     BrieflyMap
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  String                         SearchName

## Msg.GetLegionMember
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetLegionMemberAck
  MessageDescriptor              Descriptor
  MapField`2                     GroupMap
  MapField`2                     MemberMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetLegionMonthly
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetLegionMonthlyAck
  MessageDescriptor              Descriptor
  MapField`2                     MonthlyMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetMailList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetMailListAck
  MessageDescriptor              Descriptor
  Boolean                        IsFinish
  RepeatedField`1                MailList
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetMemoryData
  MessageDescriptor              Descriptor
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID

## Msg.GetMemoryDataAck
  MapField`2                     Base
  MapField`2                     Briefly
  MessageDescriptor              Descriptor
  RepeatedField`1                FinishTaskID
  RepeatedField`1                GetTaskID
  MapField`2                     ItemCD
  MapField`2                     ItemData
  RepeatedField`1                ItemIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     ResetCount
  UInt32                         RetCode
  MapField`2                     ShortKey
  MapField`2                     Skill
  MapField`2                     Store
  MapField`2                     TaskData
  MapField`2                     Vitality

## Msg.GetMeridiansInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID

## Msg.GetMeridiansInfoAck
  MessageDescriptor              Descriptor
  MeridiansGraphInfo             GraphInfo
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  MeridiansPointInfo             PointInfo
  UInt32                         Remaining
  UInt32                         RetCode

## Msg.GetMeridiansRankTop
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RankType

## Msg.GetMeridiansRankTopAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                RankInfo
  UInt32                         RankType
  UInt32                         RetCode

## Msg.GetMoneyManagementData
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetMoneyManagementDataAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetNewKey
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetNewKeyAck
  MessageDescriptor              Descriptor
  String                         Key
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          Time

## Msg.GetNewPlayerGuide
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetNewPlayerGuideAck
  MessageDescriptor              Descriptor
  RepeatedField`1                GroupIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetNewPlayerGuideNtfAck
  MessageDescriptor              Descriptor
  RepeatedField`1                GroupIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetNotifyLegion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetNotifyLegionAck
  MessageDescriptor              Descriptor
  Int64                          LastNotifyTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     RecordMap
  UInt32                         RetCode

## Msg.GetOneTask
  MessageDescriptor              Descriptor
  Boolean                        IsGetOne
  Boolean                        IsTraceNoLevel
  Boolean                        IsUseTicket
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskID

## Msg.GetOneTaskAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  TaskNode                       TaskData

## Msg.GetPlayerBaron
  UInt32                         BaronID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetPlayerBase
  MessageDescriptor              Descriptor
  Boolean                        NeedAll
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  Int64                          Time

## Msg.GetPlayerBaseAck
  PlayerBase                     BaseInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.GetPlayerItemCd
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetPlayerItemCdAck
  MapField`2                     CDMap
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetPlayerPackageData
  MessageDescriptor              Descriptor
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetPlayerPackageDataAck
  MapField`2                     CellMap
  MessageDescriptor              Descriptor
  UInt32                         MaxCellSize
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetPlayerSkill
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetPlayerSkillAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SkillMap

## Msg.GetPlayingMethodInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PlayingType

## Msg.GetPlayingMethodInfoAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PlayingType
  UInt32                         RemainingNumber
  UInt32                         RetCode

## Msg.GetQieCuoRecord
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetQiecuoRecordAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetRankData
  MessageDescriptor              Descriptor
  Boolean                        IsToday
  UInt32                         Page
  UInt32                         PageSize
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RANK_TYPE                      RankType

## Msg.GetRankDataAck
  MessageDescriptor              Descriptor
  Boolean                        IsToday
  RepeatedField`1                Lists
  UInt32                         Page
  UInt32                         PageSize
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RANK_TYPE                      RankType
  UInt32                         RetCode
  UInt32                         Total

## Msg.GetRechargeData
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetRechargeDataAck
  MessageDescriptor              Descriptor
  UInt32                         FirstRechargeClaim
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetRecordPoint
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetRecordPointAck
  MessageDescriptor              Descriptor
  MapField`2                     MapInfos
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetRegionLoginServer
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RegionID
  String                         Token

## Msg.GetRegionLoginServerAck
  MessageDescriptor              Descriptor
  ServerHost                     Host
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RegionID
  UInt32                         RetCode

## Msg.GetRelationshipIdList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetRelationshipIdListAck
  MessageDescriptor              Descriptor
  RepeatedField`1                FriendIdList
  MapField`2                     OtherIDMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetRelationshipList
  MessageDescriptor              Descriptor
  GUAN_XI_TYPE                   GuanXiType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetRelationshipListAck
  MessageDescriptor              Descriptor
  RepeatedField`1                FriendList
  GUAN_XI_TYPE                   GuanXiType
  RepeatedField`1                JieBaiList
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                QingLvList
  UInt32                         RetCode
  RepeatedField`1                ShiTuList

## Msg.GetRemainingTime
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetRemainingTimeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          RemainingTime
  UInt32                         RetCode

## Msg.GetResistList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetResistListAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                ResistList
  UInt32                         RetCode

## Msg.GetSanGuoDianConsumeData
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetSanGuoDianConsumeDataAck
  MapField`2                     DailyClaimMap
  UInt32                         DailyConsume
  MessageDescriptor              Descriptor
  MapField`2                     MonthClaimMap
  UInt32                         MonthConsume
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     WeeklyClaimMap
  UInt32                         WeeklyConsume

## Msg.GetSealRankTop
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetSealRankTopAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                RankInfo
  UInt32                         RetCode

## Msg.GetSealStone
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetSealStoneAck
  UInt32                         ClaimSign
  UInt32                         ConfigID
  UInt32                         ConvertNum
  UInt32                         CurrPhase
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PlayerNum
  UInt32                         RetCode

## Msg.GetSelfSellSgdList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetSelfSellSgdListAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetSellSgdList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetSellSgdListAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     RecommendMap
  UInt32                         RetCode
  UInt32                         SellCount
  UInt32                         UpCount

## Msg.GetServerTime
  Int64                          ClientTime
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetServerTimeAck
  Int64                          ClientTime
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          ServerTime

## Msg.GetShopScoreConsumeData
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetShopScoreConsumeDataAck
  MessageDescriptor              Descriptor
  MapField`2                     MonthClaimMap
  UInt32                         MonthConsume
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     TotalClaimMap
  UInt32                         TotalConsume

## Msg.GetSignInData
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetSignInDataAck
  MapField`2                     CycleMap
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SignInMap

## Msg.GetSkillSetting
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetSkillSettingAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SettingMap

## Msg.GetStallsInfoList
  MessageDescriptor              Descriptor
  Boolean                        IsOnlyGetSelfStalls
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                StallsInstIDs

## Msg.GetStallsInfoListAck
  MessageDescriptor              Descriptor
  Boolean                        IsOnlyGetSelfStalls
  MapField`2                     ItemMaps
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetStallsRecordList
  MessageDescriptor              Descriptor
  UInt32                         Page
  UInt32                         PageSize
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetStallsRecordListAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  UInt32                         Page
  UInt32                         PageSize
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Total

## Msg.GetSubJobLv
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetSubJobLvAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SubJobLvMap

## Msg.GetTaskAward
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskID

## Msg.GetTaskAwardAck
  RepeatedField`1                Award
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         TaskID

## Msg.GetTaskList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetTaskListAck
  MessageDescriptor              Descriptor
  UInt32                         GuoLingCount
  UInt32                         LegionCount
  UInt32                         MerchantEntrust
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         RingCount
  MapField`2                     TaskMap
  UInt32                         YsRingCount

## Msg.GetTeamList
  MessageDescriptor              Descriptor
  Boolean                        GetOnlySelfTeam
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetTeamListAck
  MessageDescriptor              Descriptor
  Boolean                        GetOnlySelfTeam
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     TeamBrieflyMap

## Msg.GetTransportGoodsInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetTransportGoodsInfoAck
  MessageDescriptor              Descriptor
  Int64                          ExpireTime
  UInt32                         FallWater
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         TargetNpcID

## Msg.GetUnlockFormula
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetUnlockFormulaAck
  SECOND_JOB_TYPE                CurrSubJob
  MessageDescriptor              Descriptor
  MapField`2                     FormulaMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GetVipInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetVipInfoAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  VipAllInfo                     VipInfo

## Msg.GetVitality
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GetVitalityAck
  MapField`2                     AlleviateMap
  UInt32                         ClaimGrade
  UInt32                         ClaimWelfare
  Int64                          DailyWelfareExp
  MessageDescriptor              Descriptor
  UInt32                         Overflow
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RefreshLv
  Int64                          RefresTime
  UInt32                         RetCode
  UInt32                         Vitality
  MapField`2                     VitalityMap
  MapField`2                     WelfareMap

## Msg.GiveGiftReward
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GiveGiftRewardAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int32                          Remaining
  UInt32                         RetCode

## Msg.Gm_AddMail
  MessageDescriptor              Descriptor
  RepeatedField`1                MailIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.Gm_AddMailAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.Gm_AddSysMessage
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.Gm_AddSysMessageAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.Gm_AddTask
  MessageDescriptor              Descriptor
  UInt32                         NeedDelTask
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskID

## Msg.Gm_AddTaskAck
  MessageDescriptor              Descriptor
  UInt32                         NeedDelTask
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         TaskID

## Msg.Gm_DisposeNewPlayerGuide
  MessageDescriptor              Descriptor
  RepeatedField`1                GroupIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.Gm_DisposeNewPlayerGuideAck
  MessageDescriptor              Descriptor
  RepeatedField`1                GroupIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.Gm_LowerWearEquipDurable
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.Gm_LowerWearEquipDurableAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmAddConditionCount
  UInt32                         AddCount
  MessageDescriptor              Descriptor
  FINISH_CONDITION_TYPE          FinishType
  UInt32                         FinshID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmAddConditionCountAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmAddEntity
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  ENTITY_TYPE                    EntityType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmAddEntityAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmAddIntimacy
  MessageDescriptor              Descriptor
  UInt32                         Intimacy
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetId

## Msg.GmAddIntimacyAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GMAddMail
  MapField`2                     AwardMap
  String                         Content
  MessageDescriptor              Descriptor
  Int64                          ExpireTime
  UInt32                         MailID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                PlayerIDs
  String                         SenderName
  String                         Sign
  String                         Title
  String                         Uuid

## Msg.GMAddMailAck
  MessageDescriptor              Descriptor
  MapField`2                     FailPlayer
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SuccessPlayer
  String                         Uuid

## Msg.GMAddOrRemoveWhiteList
  MessageDescriptor              Descriptor
  String                         OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         UID

## Msg.GMAddOrRemoveWhiteListAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmAddPlayerExp
  Int64                          AddExp
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmAddPlayerExpAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmAddRankData
  MessageDescriptor              Descriptor
  Int64                          Param1
  UInt32                         Param2
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  RANK_TYPE                      RankType

## Msg.GmAddRankDataAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RANK_TYPE                      RankType
  UInt32                         RetCode

## Msg.GmAddSignValue
  UInt32                         AddValue
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmAddSignValueAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmAddSkillExp
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SkillExp
  UInt32                         SkillID

## Msg.GmAddSkillExpAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmAddVitality
  UInt32                         AddValue
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmAddVitalityAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Vitality

## Msg.GmAddYuanShenExp
  Boolean                        AddAllYs
  Int64                          AddExp
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmAddYuanShenExpAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GMChangeFixedNum
  MapField`2                     ChangePlayerMap
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GMChangeFixedNumAck
  MessageDescriptor              Descriptor
  MapField`2                     FailPlayer
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmChangeJoinLegionTime
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmChangeJoinLegionTimeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmChangeYsGrowth
  Int32                          Change
  MessageDescriptor              Descriptor
  Boolean                        IsChangeAll
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmChangeYsGrowthAck
  Int32                          Change
  MessageDescriptor              Descriptor
  Boolean                        IsChangeAll
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmClearItemBindTime
  MessageDescriptor              Descriptor
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmClearItemBindTimeAck
  MessageDescriptor              Descriptor
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmClearSkillCd
  UInt32                         ClearType
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmClearSkillCdAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmDropInfo
  UInt32                         Count
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     PropMap

## Msg.GMForceCompletionTask
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID

## Msg.GMForceCompletionTaskAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GMGetOnlineNum
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Boolean                        RefreshNow

## Msg.GMGetOnlineNumAck
  MessageDescriptor              Descriptor
  MapField`2                     LineMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Boolean                        RefreshNow
  UInt32                         RetCode

## Msg.GMGiftCodeReward
  MessageDescriptor              Descriptor
  String                         Nonce
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  MapField`2                     RewardMap
  Int64                          Time

## Msg.GMGiftCodeRewardAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.GMModifyAccountFreeze
  String                         Account
  MessageDescriptor              Descriptor
  Int64                          FreezeTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GMModifyAccountFreezeAck
  String                         Account
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GMModifyPlayerFreeze
  MessageDescriptor              Descriptor
  Int64                          FreezeTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                PlayerIDs

## Msg.GMModifyPlayerFreezeAck
  MessageDescriptor              Descriptor
  RepeatedField`1                FailPlayerIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GMOpenOrCloseWhiteList
  MessageDescriptor              Descriptor
  String                         OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GMOpenOrCloseWhiteListAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GMOptLimit
  MessageDescriptor              Descriptor
  Boolean                        IsAdd
  OPERATE_TYPE                   OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                PlayerID
  Int64                          Time

## Msg.GMOptLimitAck
  MessageDescriptor              Descriptor
  RepeatedField`1                FailPlayerIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GMRemoveMail
  MessageDescriptor              Descriptor
  RepeatedField`1                MailInstIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GMRemoveMailAck
  MessageDescriptor              Descriptor
  RepeatedField`1                FailMailIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmRerandTalentSkill
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SkillCount
  UInt64                         TargetID

## Msg.GmRerandTalentSkillAck
  TalentData                     Data
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID

## Msg.GmResetUseCount
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmResetUseCountAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmResetVitality
  UInt32                         AddGetbackDay
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmResetVitalityAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmSetAttrib
  ATTRIBUTE                      Attrib
  Int32                          Change
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmSetAttribAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmSetEquip
  MessageDescriptor              Descriptor
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SetID
  UInt32                         SetVal
  UInt32                         Type

## Msg.GmSetEquipAck
  MessageDescriptor              Descriptor
  ItemData                       ItemData
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmSetLegionGatherProgress
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Progress

## Msg.GmSetLegionGatherProgressAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmSetPractice
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SetConfigID
  Int64                          SetExp

## Msg.GmSetPracticeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmSetResist
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          SetExp
  UInt32                         SetLv
  UInt32                         Type

## Msg.GmSetResistAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GMSetServerMaintenance
  Int64                          CloseTime
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GMSetServerMaintenanceAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmSetTalentQualification
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SetValue
  UInt64                         TargetID

## Msg.GmSetTalentQualificationAck
  TalentData                     Data
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID

## Msg.GmSetYsSkillCount
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SetCount

## Msg.GmSetYsSkillCountAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         SetCount

## Msg.GmSetYueKaExpired
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmSetYueKaExpiredAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmTestDrop
  UInt32                         Count
  MessageDescriptor              Descriptor
  UInt32                         DropID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmTestDropAck
  RepeatedField`1                AllDrops
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GmTestDungeon
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmTestDungeonAck
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     StatMap

## Msg.GmTestStatNode
  MessageDescriptor              Descriptor
  UInt32                         DropID
  MapField`2                     DropMap
  UInt32                         ExclusiveDropID
  UInt32                         KillCount
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GmTransferTo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PointID

## Msg.GmTransferToAck
  MessageDescriptor              Descriptor
  UInt32                         MapID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GoodsNode
  UInt32                         BuyCount
  MessageDescriptor              Descriptor
  UInt32                         GlobalBuyCount
  Int64                          NextResetTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GotoLegionDemesne
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.GotoLegionDemesneAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.GrpcMsg
  MessageDescriptor              Descriptor
  ByteString                     MsgBody
  UInt32                         MsgID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.HttpTransMsg
  MessageDescriptor              Descriptor
  ByteString                     MsgBody
  UInt32                         MsgID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.HyperlinkPlayer
  PlayerBriefly                  BriefData
  MessageDescriptor              Descriptor
  UInt32                         MenuOption
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.IntimacyEpithetNode
  MessageDescriptor              Descriptor
  UInt32                         Gender
  UInt32                         GuanXiType
  Int64                          Intimacy
  String                         Name
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.InviteLegion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.InviteLegionAck
  MessageDescriptor              Descriptor
  PlayerBriefly                  InviteInfo
  UInt64                         LegionID
  String                         LegionName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  String                         Sign

## Msg.ItemData
  AppearanceData                 Appearance
  Int64                          BindTime
  MessageDescriptor              Descriptor
  EquipData                      Equip
  Int64                          GetItemTime
  UInt64                         InstID
  UInt32                         ItemID
  Int64                          ItemNum
  Int64                          LockTime
  Int64                          OverdueTime
  UInt64                         OwnerID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Boolean                        ShowRedDots
  Int64                          SortTime
  TalentData                     Talent
  YsData                         Ys

## Msg.JieBaiData
  MapField`2                     AttribMap
  PlayerBriefly                  Briefly
  MessageDescriptor              Descriptor
  Int64                          Intimacy
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RemainingPoint
  UInt32                         TaskStage

## Msg.KickLegion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.KickLegionAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID
  String                         TargetName

## Msg.KickoutPlayer
  MessageDescriptor              Descriptor
  UInt32                         FromLineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         TipsCode

## Msg.KillNotifyAck
  MessageDescriptor              Descriptor
  OPERATE_TYPE                   Opt
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID
  String                         TargetName

## Msg.KlotskiChallengeResult
  Boolean                        ChallengeResult
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.KlotskiChallengeResultAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  RepeatedField`1                Rewards

## Msg.LearnSkill
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SkillID

## Msg.LearnSkillAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SettingMap
  UInt32                         SkillID

## Msg.LeaveLegion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LeaveLegionAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionAddedMemberAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID
  String                         TargetName

## Msg.LegionApplyNode
  Int64                          ApplyTime
  MessageDescriptor              Descriptor
  JOB_TYPE                       Job
  UInt32                         Level
  String                         Name
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  JOB_TALENT_TYPE                TalentJob

## Msg.LegionBase
  String                         Announcement
  UInt32                         ApplyCount
  UInt32                         ApplyDungeonType
  UInt32                         Asset
  UInt32                         Authority
  UInt32                         BattleCamp
  UInt32                         BattleState
  MapField`2                     ClaimWelfare
  UInt32                         Contribution
  COUNTRY_TYPE                   Country
  MessageDescriptor              Descriptor
  UInt32                         DungeonApplyConfigID
  UInt32                         DungeonApplyCount
  UInt64                         DungeonApplyTime
  Boolean                        DungeonInvited
  UInt32                         DungeonJoinTimes
  UInt32                         DungeonProgress
  UInt32                         DungeonScoreID
  UInt32                         DungeonState
  UInt32                         Exp
  UInt32                         GatherCount
  UInt32                         GatherMapID
  LEGION_GATHER_TYPE             GatherType
  UInt64                         ID
  Int64                          JoinTime
  UInt32                         LastEvaluate
  UInt32                         LastRewardState
  UInt64                         LeaderID
  String                         LeaderName
  String                         LegionName
  UInt32                         Level
  UInt32                         Members
  Int64                          NextResetTime
  MessageParser`1                Parser
  Int64                          PartyEndTime
  String                         PartyOpenTime
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          ReduceTime
  MapField`2                     TaskCount
  UInt32                         TotalComplete
  UInt32                         Voucher
  UInt32                         WelfareComplete

## Msg.LegionBattleApply
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionBattleApplyAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionBattleBrief
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionBattleBriefAck
  UInt32                         BattleSize1
  UInt32                         BattleSize2
  MessageDescriptor              Descriptor
  UInt64                         EndTimeMs
  UInt32                         MyCamp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Score1
  UInt32                         Score2
  String                         TargetLegionName

## Msg.LegionBattleDetail
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionBattleDetailAck
  RepeatedField`1                AllMembs
  MessageDescriptor              Descriptor
  UInt64                         EndTimeMs
  LegionBattleInfo               Info1
  LegionBattleInfo               Info2
  UInt32                         MyCamp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionBattleFight
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionBattleFightAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionBattleInfo
  UInt32                         BattleResult
  UInt32                         BattleSize
  UInt32                         Camp
  MessageDescriptor              Descriptor
  UInt64                         LegionID
  String                         LegionName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Score

## Msg.LegionBattleMember
  UInt32                         Camp
  UInt32                         DeadNum
  MessageDescriptor              Descriptor
  UInt32                         KillNum
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         Score

## Msg.LegionBriefly
  COUNTRY_TYPE                   Country
  Int64                          CreateTime
  MessageDescriptor              Descriptor
  UInt64                         LeaderID
  String                         LeaderName
  String                         LegionName
  UInt32                         Level
  String                         Manifesto
  UInt32                         Members
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionDungeonApply
  UInt32                         ApplyType
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                PlayerIDs

## Msg.LegionDungeonApplyAck
  MessageDescriptor              Descriptor
  UInt32                         DungeonApplyConfigID
  UInt32                         DungeonState
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionDungeonBestInfo
  MessageDescriptor              Descriptor
  UInt64                         ID
  UInt64                         LeaderID
  String                         LeaderName
  UInt64                         LeftTime
  String                         LegionName
  UInt32                         Level
  UInt32                         Members
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         ProgressID

## Msg.LegionDungeonDetail
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionDungeonDetailAck
  MessageDescriptor              Descriptor
  LegionDungeonDetailInfo        Detail
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionDungeonDetailInfo
  LegionDungeonBestInfo          BestInfo
  UInt32                         ConfigId
  RepeatedField`1                CureRank
  MessageDescriptor              Descriptor
  UInt32                         DungeonState
  RepeatedField`1                HurtBossRank
  RepeatedField`1                HurtMonsterRank
  UInt64                         LeftTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  LegionDungeonPersonInfo        PersonInfo
  UInt32                         ProgressID

## Msg.LegionDungeonDetailNtfAck
  MessageDescriptor              Descriptor
  LegionDungeonDetailInfo        Detail
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionDungeonFight
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionDungeonFightAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionDungeonFightAckNtf
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionDungeonInvite
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                PlayerIDs

## Msg.LegionDungeonInviteAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionDungeonInviteOpt
  UInt32                         ConfigId
  MessageDescriptor              Descriptor
  UInt32                         InviteAck
  UInt64                         LegionID
  Int64                          LimitTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerId
  String                         Sign

## Msg.LegionDungeonInviteOptAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionDungeonInviteOtherAck
  UInt32                         ConfigId
  MessageDescriptor              Descriptor
  UInt64                         LegionID
  Int64                          LimitTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerId
  UInt32                         RetCode
  String                         Sign

## Msg.LegionDungeonPersonInfo
  UInt64                         Asset
  MessageDescriptor              Descriptor
  UInt64                         Exp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         ScoreID
  UInt64                         TrialPoint

## Msg.LegionDungeonRankInfo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         RankID
  UInt64                         RankValue

## Msg.LegionEvaluateReward
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionEvaluateRewardAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionGoodsBuyRecord
  MessageDescriptor              Descriptor
  UInt32                         ItemCnt
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  Int64                          Time

## Msg.LegionMember
  UInt32                         Authority
  UInt32                         Contribution
  MessageDescriptor              Descriptor
  UInt32                         DungeonAckType
  UInt32                         DungeonJoinTimes
  GENDER_TYPE                    Gender
  UInt32                         GroupID
  Boolean                        IsOnline
  JOB_TYPE                       Job
  Int64                          JoinTime
  UInt32                         Level
  UInt32                         LineID
  String                         Name
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  JOB_TALENT_TYPE                TalentJob
  UInt64                         TeamID
  UInt32                         Voucher

## Msg.LegionMonthly
  UInt32                         BattleCount
  UInt32                         CastleBattle
  UInt32                         Contribution
  MessageDescriptor              Descriptor
  UInt32                         Dungeon
  UInt32                         GatherCount
  Boolean                        IsOnline
  JOB_TYPE                       Job
  Int64                          JoinTime
  UInt32                         LastContribution
  UInt32                         LastEvaluate
  UInt32                         Level
  String                         Name
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  JOB_TALENT_TYPE                TalentJob
  UInt32                         TaskCount
  UInt32                         WelfareCount

## Msg.LegionRecord
  MessageDescriptor              Descriptor
  UInt64                         InstID
  OPERATE_TYPE                   OptType
  Int64                          Param
  RepeatedField`1                Params
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          Time

## Msg.LegionStudyData
  UInt32                         BuyNumberMax
  UInt64                         ContributionLimit
  MessageDescriptor              Descriptor
  UInt32                         ID
  UInt32                         Level
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionStudyGoodsBuy
  UInt32                         BuyCnt
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TargetID

## Msg.LegionStudyGoodsBuyAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionStudyGoodsBuyHistory
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionStudyGoodsBuyHistoryAck
  MessageDescriptor              Descriptor
  RepeatedField`1                List
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionStudyGoodsData
  UInt64                         ContributionLimit
  MessageDescriptor              Descriptor
  UInt32                         ID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PersonBuyNumber
  UInt32                         TotalBuyNumber
  UInt32                         TotalBuyNumberMax

## Msg.LegionStudyGoodsList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionStudyGoodsListAck
  MessageDescriptor              Descriptor
  MapField`2                     Infos
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionStudyLimit
  UInt32                         BuyNumberMax
  UInt64                         ContributionLimit
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TargetID

## Msg.LegionStudyLimitAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  LegionStudyData                TargetInfo

## Msg.LegionStudyList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LegionStudyListAck
  MessageDescriptor              Descriptor
  MapField`2                     Infos
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.LegionStudyUpgrade
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TargetID

## Msg.LegionStudyUpgradeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  LegionStudyData                TargetInfo

## Msg.LimitValue
  MessageDescriptor              Descriptor
  Int32                          MaxValue
  Int32                          MinValue
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LineNode
  MessageDescriptor              Descriptor
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  SERVER_STATUS                  Status

## Msg.LockTrade
  MessageDescriptor              Descriptor
  RepeatedField`1                Packs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.LockTradeAck
  MessageDescriptor              Descriptor
  RepeatedField`1                Items
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  String                         Sign
  Int64                          Time

## Msg.LogicGrid
  Int32                          Col
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int32                          Row

## Msg.LogStruct
  String                         AppName
  MessageDescriptor              Descriptor
  String                         File
  String                         Level
  UInt32                         Line
  String                         Message
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Stack
  Int64                          Time

## Msg.Mail
  RepeatedField`1                Args
  RepeatedField`1                Awards
  String                         Content
  Int64                          DelayTime
  MessageDescriptor              Descriptor
  Int64                          ExpireTime
  String                         ExpParam
  Boolean                        IsAward
  Boolean                        IsGol
  Boolean                        IsRead
  String                         LinkStr
  UInt32                         MailID
  UInt64                         MailInstID
  UInt32                         Operate
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         SenderName
  Int64                          SendTime
  String                         Title

## Msg.MailParam
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PropParam                      PropData
  UInt32                         Type
  UInt64                         Value

## Msg.MapPosInfo
  MessageDescriptor              Descriptor
  UInt32                         MapID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos

## Msg.MerchantEntrust
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskID

## Msg.MerchantEntrustAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         TaskID

## Msg.MeridiansGraphInfo
  MessageDescriptor              Descriptor
  MapField`2                     GraphActive
  MapField`2                     GraphMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.MeridiansGraphNode
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                PointIDs

## Msg.MeridiansPointInfo
  UInt32                         AllowSee
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     PointMap

## Msg.MeridiansPointNode
  MessageDescriptor              Descriptor
  UInt32                         GraphID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Select

## Msg.ModifyAnnouncementLegion
  String                         Announcement
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ModifyAnnouncementLegionAck
  String                         Announcement
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ModifyGroupNameLegion
  MessageDescriptor              Descriptor
  UInt32                         GroupID
  String                         GroupName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ModifyGroupNameLegionAck
  MessageDescriptor              Descriptor
  UInt32                         GroupID
  String                         GroupName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ModifyNotifyLegion
  MessageDescriptor              Descriptor
  String                         Notify
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         RemoveID

## Msg.ModifyNotifyLegionAck
  MessageDescriptor              Descriptor
  String                         Notify
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         RemoveID
  UInt32                         RetCode

## Msg.ModifyViceAuthorityLegion
  UInt32                         Authority
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.ModifyViceAuthorityLegionAck
  UInt32                         Authority
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID

## Msg.MoneyClaimNode
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Remaining
  UInt32                         YearDay

## Msg.MoneyCoinConverSGD
  MessageDescriptor              Descriptor
  UInt32                         MoneyCoin
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.MoneyCoinConverSgdAck
  MessageDescriptor              Descriptor
  UInt32                         MoneyCoin
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         SGDNum

## Msg.MoneyMangementNode
  MapField`2                     ClaimMap
  MessageDescriptor              Descriptor
  UInt32                         GroupID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.MonsterDeathAck
  RepeatedField`1                CollideBoxs
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 Direction
  UInt64                         EntityID
  RepeatedField`1                ItemBoxs
  OPERATE_TYPE                   OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  Int64                          RemoveBodyTime
  UInt32                         RetCode

## Msg.MonsterUpdateAngerAck
  UInt32                         Anger
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  OPERATE_TYPE                   OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.MonthSignInValue
  UInt32                         ClaimCount
  UInt32                         CurrValue
  MessageDescriptor              Descriptor
  UInt32                         Month
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.MoveToPos
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.MoveToPosAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  DIRECTION_TYPE                 JoyStickDir
  PixelsPos                      MoveToPos
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  ENTITY_STATUS                  Status

## Msg.NotifyDeposit
  Int64                          CreateTime
  MessageDescriptor              Descriptor
  Int64                          EndTime
  String                         OrderData
  String                         OrderID
  String                         Param
  MessageParser`1                Parser
  String                         PayMoney
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SanGuoDian
  String                         Token
  String                         TradeStatus

## Msg.NotifyDepositAck
  MessageDescriptor              Descriptor
  String                         OrderID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.NotifyPkValueEventAck
  String                         DeathPlayerName
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PkValue
  UInt32                         RetCode

## Msg.NpcChatComplete
  MessageDescriptor              Descriptor
  UInt32                         NPCID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskID

## Msg.NpcChatCompleteAck
  MessageDescriptor              Descriptor
  UInt32                         NPCID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         TaskID

## Msg.OpenKlotskiChallenge
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.OpenKlotskiChallengeAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  Int64                          EndTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.OpenPeriod
  String                         CloseTime
  UInt32                         DayOfWeek
  MessageDescriptor              Descriptor
  String                         OpenTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.OptApplyRelationship
  Boolean                        Agree
  UInt64                         ApplyID
  MessageDescriptor              Descriptor
  GUAN_XI_TYPE                   GuanXiType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.OptApplyRelationshipAck
  Boolean                        Agree
  UInt64                         ApplyID
  MessageDescriptor              Descriptor
  GUAN_XI_TYPE                   GuanXiType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  GENDER_TYPE                    TargetGender
  UInt64                         TargetID
  String                         TargetName

## Msg.OptApplyTeam
  Boolean                        Agree
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerId

## Msg.OptApplyTeamAck
  MapField`2                     ApplyMap
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.OptApplyTrade
  Boolean                        Agree
  UInt64                         ApplyID
  MessageDescriptor              Descriptor
  Int64                          LimitTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Sign

## Msg.OptApplyTradeAck
  Boolean                        Agree
  PlayerBriefly                  Briefly
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.OptBankNum
  MessageDescriptor              Descriptor
  Boolean                        IsSaveIn
  Int64                          OptNum
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.OptBankNumAck
  MessageDescriptor              Descriptor
  Boolean                        IsSaveIn
  Int64                          OptNum
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.OptCallMembersTeam
  Boolean                        Agree
  MessageDescriptor              Descriptor
  Int64                          LimitTime
  UInt32                         LineID
  UInt32                         MapID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         RetCode
  String                         Sign
  UInt64                         SummonerID
  String                         SummonerName

## Msg.OptCallMembersTeamAck
  Boolean                        Agree
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerId
  UInt32                         RetCode

## Msg.OptInviteLegion
  Boolean                        Agree
  MessageDescriptor              Descriptor
  UInt64                         InviteID
  Int64                          InviteTime
  UInt64                         LegionID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Sign

## Msg.OptInviteLegionAck
  Boolean                        Agree
  LegionBase                     BaseInfo
  MessageDescriptor              Descriptor
  UInt64                         InviteID
  UInt64                         LegionID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.OptMeridiansGraph
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  UInt32                         Index
  UInt32                         OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PointID

## Msg.OptMeridiansGraphAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  UInt32                         Index
  UInt32                         OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PointID
  UInt32                         RetCode

## Msg.OptPrivWarehouse
  MessageDescriptor              Descriptor
  PACK_TYPE                      InPackType
  UInt64                         ItemInstID
  Int64                          ItemNum
  PACK_TYPE                      OutPackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          PrivateTime
  String                         PrivateToken

## Msg.OptPrivWarehouseAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.OptSummonFriend
  Boolean                        Agree
  MessageDescriptor              Descriptor
  Int64                          LimitTime
  UInt32                         LineID
  UInt32                         MapID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  String                         Sign
  UInt64                         SummonerID

## Msg.OptSummonFriendAck
  Boolean                        Agree
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         SummonerID
  UInt64                         TargetID

## Msg.OptTalentBookMix
  MessageDescriptor              Descriptor
  UInt64                         DestroyID
  Boolean                        IsProtect
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  TalentMixParam                 PreData
  JOB_TALENT_TYPE                WearJob

## Msg.OptTalentBookMixAck
  TalentData                     Data
  MessageDescriptor              Descriptor
  Boolean                        IsProtect
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  JOB_TALENT_TYPE                WearJob

## Msg.OptTalentBookWash
  String                         CheckSign
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     PreMap
  Int64                          SaveEndTime
  UInt32                         WashType
  JOB_TALENT_TYPE                WearJob

## Msg.OptTalentBookWashAck
  TalentData                     Data
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Boolean                        ResetAll
  UInt32                         RetCode
  UInt32                         WashType
  JOB_TALENT_TYPE                WearJob

## Msg.OptTeamBriefly
  TeamBriefly                    Briefly
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Boolean                        SendLoop
  UInt32                         TypeOpt

## Msg.OptTeamBrieflyAck
  MessageDescriptor              Descriptor
  Boolean                        IsClear
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Boolean                        SendLoop
  UInt32                         TypeOpt

## Msg.OptTeamExit
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.OptTeamExitAck
  TeamBriefly                    Briefly
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.OptTeamInvite
  Boolean                        Agree
  MessageDescriptor              Descriptor
  Int64                          LimitTime
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         SendPlayerId
  String                         Sign
  UInt64                         TeamId

## Msg.OptTeamInviteAck
  Boolean                        Agree
  MessageDescriptor              Descriptor
  ServerHost                     Host
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.OptTeamInviteAckNtf
  Boolean                        Agree
  MessageDescriptor              Descriptor
  String                         Name
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.OptTeamReady
  Boolean                        Agree
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.OptTeamReadyAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     PlayerReadyMap
  UInt32                         RetCode

## Msg.OptTeamSendInvite
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerId

## Msg.OptTeamSendInviteAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.OptTeamSendInviteOtherAck
  UInt32                         ConfigId
  MessageDescriptor              Descriptor
  Int64                          LimitTime
  UInt32                         LineID
  LimitValue                     Lv
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerId
  UInt32                         RetCode
  String                         Sign
  UInt64                         TeamId
  TARGET_CONTENT_TYPE            Type

## Msg.OptTeamTick
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerId

## Msg.OptTeamTickAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.OptWarehousePackage
  MessageDescriptor              Descriptor
  UInt64                         ItemInstID
  Int64                          ItemNum
  PACK_TYPE                      OutPackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.OptWarehousePackageAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.PauseDoubleExpButton
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.PauseDoubleExpButtonAck
  Int64                          ButtonColdTime
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          RemainingTime
  UInt32                         RetCode

## Msg.PauseQixinxieliButton
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.PauseQixinxieliButtonAck
  Int64                          ButtonColdTime
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          RemainingTime
  UInt32                         RetCode

## Msg.PauseRingTask
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskID

## Msg.PauseRingTaskAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.PbRankData
  COUNTRY_TYPE                   Country
  MessageDescriptor              Descriptor
  JOB_TYPE                       Job
  Int64                          Param1
  UInt32                         Param2
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         PlayerLevel
  String                         PlayerName
  JOB_TALENT_TYPE                TalentJob

## Msg.PickupItem
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                PickupID

## Msg.PickupItemAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     UpdateNum

## Msg.PixelsPos
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Single                         X
  Single                         Y

## Msg.PlayerAddExpAck
  Int64                          AddExp
  UInt32                         AddLevel
  UInt32                         CurrLevel
  MessageDescriptor              Descriptor
  OPERATE_TYPE                   ExpSource
  Int64                          FinalExp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  Int64                          RealAddExp
  UInt32                         RetCode

## Msg.PlayerBase
  MapField`2                     AppearancePackage
  MapField`2                     AttribMap
  UInt32                         BaronID
  UInt32                         BattleScore
  UInt32                         BitSign
  COUNTRY_TYPE                   CampCountry
  COUNTRY_TYPE                   Country
  SECOND_JOB_TYPE                CurrSubJob
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 Direction
  UInt32                         DljpNum
  Int64                          DonotTouchMeTime
  UInt32                         EffectSign
  UInt32                         EpithetID
  ExpFatigueData                 ExpFatigue
  GENDER_TYPE                    Gender
  UInt32                         Hairstyle
  UInt32                         HairstyleColor
  IntimacyEpithetNode            IntimacyEpithet
  JOB_TYPE                       Job
  DIRECTION_TYPE                 JoyStickDir
  UInt32                         LastMapID
  UInt32                         LegionAuthority
  UInt32                         LegionGather
  LEGION_GATHER_TYPE             LegionGatherType
  String                         LegionGroupName
  UInt64                         LegionID
  UInt32                         LegionLevel
  String                         LegionName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         PlayerLevel
  String                         PlayerName
  PixelsPos                      Pos
  MapField`2                     PracticeMap
  Int64                          Rascality
  Boolean                        SetFight
  String                         Signature
  YsSkin                         SkinSet
  ENTITY_STATUS                  Status
  JOB_TALENT_TYPE                TalentJob
  MapField`2                     TalentPackage
  MapField`2                     TalentSkillMap
  UInt64                         TeamID
  UInt64                         VehiclesInstID
  VipBaseInfo                    Vip
  MapField`2                     WearPackage
  UInt32                         YsConfigID
  UInt32                         YsFuGuiID
  UInt64                         YsInstID
  String                         YsName
  UInt32                         YsScore
  YS_SHOW                        YsShow
  Int64                          YueKaTime

## Msg.PlayerBriefly
  UInt32                         BattleScore
  COUNTRY_TYPE                   Country
  MessageDescriptor              Descriptor
  GENDER_TYPE                    Gender
  Boolean                        IsOnline
  JOB_TYPE                       Job
  String                         LegionName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         PlayerLevel
  String                         PlayerName
  JOB_TALENT_TYPE                TalentJob
  UInt64                         TeamId
  Int64                          Time

## Msg.PlayerManualUpLv
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.PlayerManualUpLvAck
  MessageDescriptor              Descriptor
  UInt32                         Level
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.PlayerNode
  MessageDescriptor              Descriptor
  GENDER_TYPE                    Gender
  JOB_TYPE                       Job
  Int64                          LastLogin
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         PlayerLv
  String                         PlayerName
  UInt32                         RegionID

## Msg.PlayerSelf
  UInt32                         AttackMode
  UInt32                         ChuShiCount
  UInt32                         CountryFightSign
  MessageDescriptor              Descriptor
  Int64                          Energy
  Int64                          Fatigue
  Int64                          FreezeTime
  UInt32                         ItemScheme
  Int64                          LastLogin
  Int64                          LastLogout
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          PlayerExp
  UInt64                         PlayerID
  Int64                          Prestige
  Int64                          RemoveTime
  UInt32                         SkillScheme
  UInt64                         StallsInstID
  Int64                          UidLastLogout

## Msg.PopPackageItemAck
  MessageDescriptor              Descriptor
  OPERATE_TYPE                   OptType
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     PopMap
  UInt32                         RetCode

## Msg.PracticeParam
  UInt32                         CurrExp
  MessageDescriptor              Descriptor
  UInt32                         Lv
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.PropParam
  MessageDescriptor              Descriptor
  UInt32                         ID
  Int64                          Num
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.PublishTask
  MessageDescriptor              Descriptor
  UInt64                         ItemInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.PublishTaskAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         PublishItemID
  UInt32                         RetCode

## Msg.PunchEquip
  MessageDescriptor              Descriptor
  Boolean                        IsUseSpecialItem
  UInt32                         JewelItemID
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.PunchEquipAck
  MessageDescriptor              Descriptor
  ItemData                       EquipData
  Boolean                        IsSucceed
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.PushXiaoLianQuestionAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Question                       QuestionParam
  UInt32                         RetCode

## Msg.PVPFightData
  MessageDescriptor              Descriptor
  UInt64                         InstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     PlayerMap

## Msg.PVPPlayerFightData
  UInt32                         DeadCount
  MessageDescriptor              Descriptor
  Int64                          EnterTime
  Int64                          ExitTime
  UInt32                         KillCount
  UInt32                         KillScore
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         Rank
  UInt32                         RankScore

## Msg.QieCuoRecord
  MessageDescriptor              Descriptor
  Int64                          FightTime
  UInt64                         LoserID
  String                         LoserName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         WinnerID
  String                         WinnerName

## Msg.QingLvData
  PlayerBriefly                  Briefly
  Int64                          CreateTime
  MessageDescriptor              Descriptor
  Int64                          Intimacy
  UInt32                         Marry
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskStage

## Msg.Question
  UInt32                         AnswerTime
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         QuestionID
  UInt32                         QuestionStep
  UInt32                         RightAnswer

## Msg.QuitXiaoLianQuestion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.QuitXiaoLianQuestionAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.RankSort
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  Int64                          Time
  Int64                          Value1
  UInt32                         Value2

## Msg.RecordTransportPoint
  MessageDescriptor              Descriptor
  UInt32                         MapPosInfoIndex
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.RecordTransportPointAck
  MessageDescriptor              Descriptor
  MapField`2                     MapInfos
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.RegionNode
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Boolean                        Recommend
  UInt32                         RegionID
  SERVER_STATUS                  Status

## Msg.RemakeEquip
  MessageDescriptor              Descriptor
  MapField`2                     MaterialMap
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.RemakeEquipAck
  MessageDescriptor              Descriptor
  ItemData                       EquipData
  Boolean                        IsSucceed
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.RemoveMeridiansPoint
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.RemoveMeridiansPointAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.RemovePlayer
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID

## Msg.ReplenishmentSignIn
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         ReplenishmentCount

## Msg.ReplenishmentSignInAck
  UInt32                         CycleSignValue
  MessageDescriptor              Descriptor
  SignInNode                     MonthData
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         ReplenishmentCount
  UInt32                         RetCode
  UInt32                         UseCount

## Msg.RequestGetGatherAward
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.RequestGetGatherAwardAck
  UInt32                         AwardNum
  MessageDescriptor              Descriptor
  Int64                          NextAwardTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.RequestStartGather
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 Direction
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt64                         TargetID

## Msg.RequestStartGatherAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          StartTime
  UInt64                         TargetID

## Msg.RequestStopGather
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.RequestStopGatherAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ResetJieBaiPoint
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.ResetJieBaiPointAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RemainingPoint
  UInt32                         RetCode
  UInt64                         TargetID

## Msg.ResetRemakeEquip
  MessageDescriptor              Descriptor
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.ResetRemakeEquipAck
  MessageDescriptor              Descriptor
  ItemData                       EquipData
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ResetRingTask
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskID

## Msg.ResetRingTaskAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ResetSlotEquip
  MessageDescriptor              Descriptor
  Boolean                        IsNeedReturn
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     ResetIdx

## Msg.ResetSlotEquipAck
  MessageDescriptor              Descriptor
  ItemData                       EquipData
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.ResetYsSkill
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         YsInstID

## Msg.ResetYsSkillAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SkillID
  UInt64                         YsInstID

## Msg.ResistParam
  UInt32                         CurrExp
  MessageDescriptor              Descriptor
  UInt32                         Lv
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Type

## Msg.RestartDoubleExpButton
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.RestartDoubleExpButtonAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.RestartQixinxieliButton
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.RestartQixinxieliButtonAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.RestartRingTask
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskID

## Msg.RestartRingTaskAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.RouteNode
  Int64                          Advance
  UInt32                         Cycle
  MessageDescriptor              Descriptor
  Int64                          InitTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                Point

## Msg.RoutePoint
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Single                         PosX
  Single                         PosY
  UInt32                         Speed
  UInt32                         Stay

## Msg.SearchConsignment
  MessageDescriptor              Descriptor
  UInt32                         Gender
  RepeatedField`1                ItemIDs
  UInt32                         Job
  UInt32                         LvEnd
  UInt32                         LvStart
  UInt32                         MainLabel
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Quality
  UInt32                         SmallLabel

## Msg.SearchConsignmentAck
  RepeatedField`1                Classifys
  MessageDescriptor              Descriptor
  UInt32                         Gender
  RepeatedField`1                ItemIDs
  UInt32                         Job
  UInt32                         LvEnd
  UInt32                         LvStart
  UInt32                         MainLabel
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Quality
  UInt32                         RetCode
  UInt32                         SmallLabel

## Msg.SellPlayerPackage
  RepeatedField`1                ChooseList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SellPlayerPackageAck
  MapField`2                     AddMap
  MessageDescriptor              Descriptor
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SellSgdInfo
  UInt32                         Amount
  MessageDescriptor              Descriptor
  Int64                          EndTime
  UInt64                         OrderID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          Price

## Msg.SellSgdSort
  UInt32                         Amount
  MessageDescriptor              Descriptor
  Int64                          EndTime
  UInt64                         OrderID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          Price
  UInt64                         SellerID
  UInt32                         SortValue

## Msg.SendChat
  CHAT_CHANNEL                   Channel
  String                         Content
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         RecverID
  String                         Sign

## Msg.SendChatAck
  CHAT_CHANNEL                   Channel
  MessageDescriptor              Descriptor
  Int64                          NextSendTime
  PlayerBriefly                  OtherBrief
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SendChatMessageAck
  CHAT_CHANNEL                   Channel
  ChatNode                       Data
  MessageDescriptor              Descriptor
  PlayerBriefly                  OtherBrief
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         SpeakerID

## Msg.SendDodgeAck
  UInt32                         DamageID
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         SkillID

## Msg.SendTeamBrieflyAck
  MapField`2                     ApplyMap
  TeamBriefly                    Briefly
  MessageDescriptor              Descriptor
  Int64                          EndTIme
  OPERATE_TYPE                   OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SendToClient
  MessageDescriptor              Descriptor
  ByteString                     PacketBytes
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          Session

## Msg.ServerDisconnectAck
  UInt32                         DelayTime
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          Session
  UInt32                         TipsCode

## Msg.ServerHost
  MessageDescriptor              Descriptor
  String                         IP
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Port

## Msg.ServerInfo
  MessageDescriptor              Descriptor
  String                         IP
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Port
  UInt32                         Status

## Msg.SetAttackMode
  UInt32                         AttackMode
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetAttackModeAck
  UInt32                         AttackMode
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SetAttributeAck
  UInt64                         AttackID
  ATTRIBUTE                      Attrute
  UInt32                         DamageID
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  Int32                          Final
  OPERATE_TYPE                   OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  SHOW_TYPE                      Show
  Int32                          ShowValue

## Msg.SetAutoItemSetting
  MessageDescriptor              Descriptor
  Boolean                        IsInitiative
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         SettingData

## Msg.SetAutoItemSettingAck
  MessageDescriptor              Descriptor
  Boolean                        IsInitiative
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  String                         SettingData

## Msg.SetAutoSkillSetting
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     SettingMap

## Msg.SetAutoSkillSettingAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SettingMap

## Msg.SetChatLastReadNum
  CHAT_CHANNEL                   Channel
  UInt64                         ChannelParam
  MessageDescriptor              Descriptor
  UInt32                         LastReadNum
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID

## Msg.SetChatLastReadNumAck
  CHAT_CHANNEL                   Channel
  UInt64                         ChannelParam
  MessageDescriptor              Descriptor
  UInt32                         LastReadNum
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SetEpithet
  MessageDescriptor              Descriptor
  UInt32                         EpithetID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  SET_TYPE                       SetType
  UInt64                         TargetID

## Msg.SetEpithetAck
  MessageDescriptor              Descriptor
  UInt32                         EpithetID
  IntimacyEpithetNode            IntimacyEpithet
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  SET_TYPE                       SetType
  UInt64                         TargetID

## Msg.SetFuncPortSetting
  MessageDescriptor              Descriptor
  Boolean                        IsInitiative
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         SettingData

## Msg.SetFuncPortSettingAck
  MessageDescriptor              Descriptor
  Boolean                        IsInitiative
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  String                         SettingData

## Msg.SetGroupLegion
  MessageDescriptor              Descriptor
  UInt32                         GroupID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                TargetIDs

## Msg.SetGroupLegionAck
  MessageDescriptor              Descriptor
  UInt32                         GroupID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  RepeatedField`1                TargetIDs

## Msg.SetItemNotRedDots
  RepeatedField`1                ChooseList
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetItemNotRedDotsAck
  MessageDescriptor              Descriptor
  RepeatedField`1                InstIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SetItemSetting
  MessageDescriptor              Descriptor
  Boolean                        IsInitiative
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         SettingData

## Msg.SetItemSettingAck
  MessageDescriptor              Descriptor
  Boolean                        IsInitiative
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  String                         SettingData

## Msg.SetJobTalent
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  JOB_TALENT_TYPE                SetJob

## Msg.SetJobTalentAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  JOB_TALENT_TYPE                SetJob

## Msg.SetJoyStickDir
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 JoyStickDir
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetJoyStickDirAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  DIRECTION_TYPE                 JoyStickDir
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SetLegionMapID
  UInt32                         Depth
  MessageDescriptor              Descriptor
  UInt32                         LastMapID
  UInt64                         LegionID
  UInt32                         MapID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetLegionName
  MessageDescriptor              Descriptor
  String                         NewName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetLegionNameAck
  MessageDescriptor              Descriptor
  UInt64                         LegionID
  String                         NewName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SetLegionPartyOpenTime
  MessageDescriptor              Descriptor
  UInt32                         Hour
  UInt32                         Minutes
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetLegionPartyOpenTimeAck
  MessageDescriptor              Descriptor
  UInt32                         Hour
  UInt32                         Minutes
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SetManifestoLegion
  Boolean                        AutoApprove
  MessageDescriptor              Descriptor
  String                         Manifesto
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetManifestoLegionAck
  Boolean                        AutoApprove
  MessageDescriptor              Descriptor
  String                         Manifesto
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SetMeridiansGraphSee
  Boolean                        AllowSee
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetMeridiansGraphSeeAck
  Boolean                        AllowSee
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SetNewPlayerGuide
  MessageDescriptor              Descriptor
  UInt32                         GroupID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetNewPlayerGuideAck
  MessageDescriptor              Descriptor
  UInt32                         GroupID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SetPlayerName
  MessageDescriptor              Descriptor
  String                         NewName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetPlayerNameAck
  MessageDescriptor              Descriptor
  String                         NewName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.SetPlayerSignature
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Signature

## Msg.SetPlayerSignatureAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  String                         Signature

## Msg.SetReadMail
  MessageDescriptor              Descriptor
  UInt64                         MailInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetReadMailAck
  MessageDescriptor              Descriptor
  UInt64                         MailInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SetRemainingTimeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          RemainingTime
  UInt32                         RetCode

## Msg.SetSign
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         SetSign_
  String                         SetType

## Msg.SetSkillSetting
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PenetrateValue
  MapField`2                     SettingMap

## Msg.SetSkillSettingAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         PenetrateValue
  UInt32                         RetCode
  MapField`2                     SettingMap

## Msg.SetSpeakerItem
  MessageDescriptor              Descriptor
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SetSpeakerItemAck
  MessageDescriptor              Descriptor
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SetStatus
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 JoyStickDir
  String                         NewKey
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Single                         PosX
  Single                         PosY
  ENTITY_STATUS                  SetStatus_
  Int32                          TestKey

## Msg.SetStatusAck
  Boolean                        ClientOpt
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  DIRECTION_TYPE                 JoyStickDir
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Single                         PosX
  Single                         PosY
  UInt32                         RetCode
  UInt32                         Speed
  ENTITY_STATUS                  Status

## Msg.SetTaskFollow
  MessageDescriptor              Descriptor
  Boolean                        IsFollow
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TaskID

## Msg.SetTaskFollowAck
  MessageDescriptor              Descriptor
  Boolean                        IsFollow
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         TaskID

## Msg.SettlementBmsAck
  UInt32                         BmsConfigID
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  PropParam                      ExpReward
  PropParam                      ExtraReward
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RemainingSecond
  UInt32                         RetCode
  UInt32                         TotalBossHp
  UInt32                         TotalKill
  UInt32                         TotalScore

## Msg.SetUseItemScheme
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         UseScheme

## Msg.SetUseItemSchemeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         UseScheme

## Msg.SetUseSkillScheme
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         UseScheme

## Msg.SetUseSkillSchemeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         UseScheme

## Msg.SetViceLegion
  MessageDescriptor              Descriptor
  Boolean                        IsAdd
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.SetViceLegionAck
  MessageDescriptor              Descriptor
  Boolean                        IsAdd
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID
  String                         TargetName

## Msg.SetYsShowType
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  YS_SHOW                        Type

## Msg.SetYsShowTypeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  YS_SHOW                        Type

## Msg.SetYsSkin
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  YsSkin                         Set

## Msg.SetYsSkinAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  YsSkin                         Set

## Msg.SGetConsignmentList
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  Int64                          LowestPrice
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Total

## Msg.SGetSellSgdList
  MessageDescriptor              Descriptor
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     RecommendMap
  UInt32                         RetCode
  UInt32                         Total

## Msg.ShiTuData
  PlayerBriefly                  Briefly
  MessageDescriptor              Descriptor
  Int64                          Intimacy
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  GUAN_XI_TYPE                   Type

## Msg.ShowTalkAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         TalkID

## Msg.SignInNode
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          RemoveTime
  UInt32                         SignIn
  MonthSignInValue               SignValue
  UInt32                         Vitality1
  UInt32                         Vitality2
  UInt32                         Vitality3

## Msg.SiXiangRefreshEquip
  MessageDescriptor              Descriptor
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SiXiangRefreshEquipAck
  MessageDescriptor              Descriptor
  ItemData                       EquipData
  ChoosePackage                  OnlyOneInst
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SkillBase
  Int64                          CoolDownTime
  MessageDescriptor              Descriptor
  UInt32                         Exp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SkillScheme
  MessageDescriptor              Descriptor
  Boolean                        IsOpenDownExpand
  Boolean                        IsOpenMiddleExpand
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     Sockets

## Msg.SkipTransportGoods
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SkipTransportGoodsAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SmeltingEquip
  MessageDescriptor              Descriptor
  UInt64                         EquipInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SmeltingGrade
  UInt32                         SmeltingType

## Msg.SmeltingEquipAck
  MessageDescriptor              Descriptor
  UInt64                         EquipInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SSAddTaskID
  MessageDescriptor              Descriptor
  UInt32                         GuanXiType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         TaskID

## Msg.SSChangeBlacklist
  MessageDescriptor              Descriptor
  Boolean                        IsAdd
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt64                         TargetID
  Int64                          Time

## Msg.SSChangeFixedNum
  Int64                          ChangeAmount
  MessageDescriptor              Descriptor
  UInt32                         FixedItemID
  UInt32                         Operate
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID

## Msg.SSClearRank
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RankType

## Msg.SSDestroyStalls
  MessageDescriptor              Descriptor
  UInt32                         MapID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         StallsInstID

## Msg.SSRankNumData
  RankSort                       Data
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RankNum
  UInt32                         RankType

## Msg.SSSetYueKaTime
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                PlayerIDs
  Int64                          SetTime
  UInt32                         SetType

## Msg.SSTestOnline
  Boolean                        ClearMem
  MessageDescriptor              Descriptor
  String                         Info
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID

## Msg.StallsInfo
  MessageDescriptor              Descriptor
  UInt32                         ItemID
  RepeatedField`1                Lists
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         SellerID
  String                         SellerName
  String                         Shout
  UInt64                         StallsID

## Msg.StallsItem
  ItemData                       Data
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          Price
  UInt32                         Remaining
  Int64                          StallsTime

## Msg.StallsRecord
  UInt64                         BuyerID
  String                         BuyerName
  UInt32                         BuyNum
  Int64                          BuyPrice
  Int64                          BuyTime
  MessageDescriptor              Descriptor
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.StartJinXiu
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         UseCount

## Msg.StartMove
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 JoyStickDir
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Single                         PosX
  Single                         PosY
  ENTITY_STATUS                  Status

## Msg.StartMoveAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  DIRECTION_TYPE                 JoyStickDir
  MessageParser`1                Parser
  RepeatedField`1                Pathway
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Single                         PosX
  Single                         PosY
  UInt32                         RetCode
  UInt32                         Speed
  ENTITY_STATUS                  Status

## Msg.StartSubJobTask
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.StartSubJobTaskAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     TaskMap

## Msg.StartXiaoLianQuestion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.StopMove
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 JoyStickDir
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Single                         PosX
  Single                         PosY
  ENTITY_STATUS                  Status

## Msg.StopMoveAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  DIRECTION_TYPE                 JoyStickDir
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Single                         PosX
  Single                         PosY
  UInt32                         RetCode
  ENTITY_STATUS                  Status

## Msg.SubJobLvUpdateAck
  UInt32                         CurrLevel
  MessageDescriptor              Descriptor
  SECOND_JOB_TYPE                NowJob
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SuccessPrices
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          Price
  Int64                          Time

## Msg.SummonFriend
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.SummonFriendAck
  MessageDescriptor              Descriptor
  Int64                          LimitTime
  UInt32                         LineID
  UInt32                         MapID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         RetCode
  String                         Sign
  UInt64                         SummonerID
  String                         SummonerName

## Msg.SwitchLine
  MessageDescriptor              Descriptor
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.SwitchLineAck
  MessageDescriptor              Descriptor
  ServerHost                     Host
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SwitchLineNtf
  MessageDescriptor              Descriptor
  OPERATE_TYPE                   Opt
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         TargetLineID
  UInt64                         TeamID

## Msg.SwitchSubJob
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  SECOND_JOB_TYPE                TargetSubJob

## Msg.SwitchSubJobAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.SwitchTargetAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID

## Msg.SyncPos
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 JoyStickDir
  String                         Key
  Boolean                        NeedBroadcast
  String                         NewKey
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Single                         PosX
  Single                         PosY
  String                         Sign
  ENTITY_STATUS                  Status
  Int32                          TestKey
  Int64                          Time

## Msg.SyncPosAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  DIRECTION_TYPE                 JoyStickDir
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Single                         PosX
  Single                         PosY
  UInt32                         RetCode
  ENTITY_STATUS                  Status

## Msg.SyncToServerAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  DIRECTION_TYPE                 JoyStickDir
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Single                         PosX
  Single                         PosY
  UInt32                         RetCode
  ENTITY_STATUS                  Status

## Msg.TalentBookAddExp
  MessageDescriptor              Descriptor
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         UseCount
  JOB_TALENT_TYPE                WearJob

## Msg.TalentBookAddExpAck
  Int64                          AddExp
  TalentData                     Data
  MessageDescriptor              Descriptor
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  JOB_TALENT_TYPE                WearJob

## Msg.TalentBookCompose
  MessageDescriptor              Descriptor
  UInt64                         DestroyID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.TalentBookComposeAck
  MessageDescriptor              Descriptor
  UInt64                         DestroyID
  UInt64                         NewInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.TalentBookMix
  MessageDescriptor              Descriptor
  UInt64                         DestroyID
  Boolean                        IsProtect
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  JOB_TALENT_TYPE                WearJob

## Msg.TalentBookMixAck
  MessageDescriptor              Descriptor
  UInt64                         DestroyID
  Boolean                        IsProtect
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  TalentMixParam                 PreData
  UInt32                         RetCode
  JOB_TALENT_TYPE                WearJob

## Msg.TalentBookWash
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         WashType
  JOB_TALENT_TYPE                WearJob

## Msg.TalentBookWashAck
  String                         CheckSign
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     PreMap
  UInt32                         RetCode
  Int64                          SaveEndTime
  UInt32                         WashType
  JOB_TALENT_TYPE                WearJob

## Msg.TalentData
  MessageDescriptor              Descriptor
  Int64                          Exp
  UInt32                         Level
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     QualificationsMap
  UInt32                         Score
  MapField`2                     SkillID
  UInt32                         UsePoint
  MapField`2                     WashMap
  UInt32                         WearJob

## Msg.TalentMixParam
  String                         CheckSign
  MessageDescriptor              Descriptor
  Boolean                        IsProtect
  Int64                          MixExp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          SaveEndTime
  MapField`2                     SkillMap
  MapField`2                     WashMap

## Msg.TalentSkillBase
  Int64                          Cd
  MessageDescriptor              Descriptor
  UInt32                         Lv
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.TalentUpSkill
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SkillID
  JOB_TALENT_TYPE                WearJob

## Msg.TalentUpSkillAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Score
  UInt32                         SkillID
  UInt32                         UsePoint
  JOB_TALENT_TYPE                WearJob

## Msg.TaskCount
  UInt32                         Curr
  MessageDescriptor              Descriptor
  UInt32                         ID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.TaskNode
  RepeatedField`1                AwardList
  UInt32                         Count
  RepeatedField`1                CountList
  MessageDescriptor              Descriptor
  Int64                          ExpirationTime
  Boolean                        IsFollow
  MessageParser`1                Parser
  Int64                          PauseTime
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PublishID
  TASK_STATUS                    Status
  UInt32                         TaskID
  UInt32                         UseQuickCount

## Msg.TaskStatusChangeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  TaskNode                       TaskNode

## Msg.TeamApplyNtf
  UInt64                         ApplyID
  UInt32                         ApplyLineID
  UInt64                         ApplyTeamID
  UInt32                         AppyLv
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.TeamApplyNtfBack
  UInt64                         ApplyID
  MessageDescriptor              Descriptor
  UInt32                         LineID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TeamID

## Msg.TeamBriefly
  UInt32                         ConfigId
  MessageDescriptor              Descriptor
  UInt64                         Id
  Boolean                        IsAutoJoin
  Boolean                        IsRecruit
  UInt64                         LeaderId
  LimitValue                     Lv
  MapField`2                     MemberMap
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Text
  TARGET_CONTENT_TYPE            Type

## Msg.TeamData
  MapField`2                     ApplyMap
  TeamBriefly                    Briefly
  UInt32                         ConfigId
  MessageDescriptor              Descriptor
  Int64                          EndTIme
  UInt64                         Id
  MapField`2                     LeaveTimeMap
  UInt64                         NewInstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     TeamAddIntimacy
  TARGET_CONTENT_TYPE            Type

## Msg.TeamFightData
  MessageDescriptor              Descriptor
  Int64                          InitTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  MapField`2                     PlayerMap
  UInt64                         TeamID
  UInt32                         TeamKill
  UInt32                         TeamRank
  UInt32                         TeamRankScore
  UInt32                         TeamScore

## Msg.TeamMember
  Int32                          DailyFreeExpFatigue
  MessageDescriptor              Descriptor
  Int32                          ExpFatigue
  Int64                          HaveNum
  UInt32                         MapID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PlayerBriefly                  PlayerBriefly
  Boolean                        Ready
  MapField`2                     RelationshipAttrib
  Int64                          Time

## Msg.TeamPlayerFightData
  UInt32                         DeadCount
  MessageDescriptor              Descriptor
  Int64                          EnterTime
  Int64                          ExitTime
  UInt32                         KillCount
  UInt32                         KillScore
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RankScore

## Msg.TestActor
  Int64                          ActorID
  MessageDescriptor              Descriptor
  String                         OrderID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.TestGmAddItem
  MapField`2                     DataMap
  MessageDescriptor              Descriptor
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.TestGmAddItemAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.TestGmDelItem
  MapField`2                     DataMap
  MessageDescriptor              Descriptor
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.TestGmDelItemAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.TestNetWork
  String                         AppName
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Boolean                        Response
  UInt32                         ServerID

## Msg.TidyPlayerPackage
  MessageDescriptor              Descriptor
  RepeatedField`1                PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.TidyPlayerPackageAck
  MessageDescriptor              Descriptor
  RepeatedField`1                PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          SortTime

## Msg.TopRankPlayerInfo
  MapField`2                     AppearancePackage
  UInt32                         BitSign
  COUNTRY_TYPE                   Country
  MessageDescriptor              Descriptor
  GENDER_TYPE                    Gender
  UInt32                         Hairstyle
  UInt32                         HairstyleColor
  JOB_TYPE                       Job
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         Rank
  JOB_TALENT_TYPE                TalentJob
  Int64                          Time
  MapField`2                     WearPackage
  UInt32                         YsFuGuiID
  YS_SHOW                        YsShow

## Msg.TransferLeaderLegion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.TransferLeaderLegionAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID
  String                         TargetName

## Msg.TrenchData
  MessageDescriptor              Descriptor
  UInt32                         Id
  UInt64                         InsId
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  TRENCH_TYPE                    Type

## Msg.TwistedEggLottery
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  TWISTED_EGG_TYPE               Type

## Msg.TwistedEggLotteryAck
  UInt32                         ConfigId
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  String                         PlayerName
  UInt32                         RetCode
  TWISTED_EGG_TYPE               Type

## Msg.UnBindItem
  ChooseOne                      ChooseInst
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Boolean                        UseItem

## Msg.UnBindItemAck
  Int64                          BindTime
  ChooseOne                      ChooseInst
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UnlockFormulaAck
  MessageDescriptor              Descriptor
  RepeatedField`1                FormulaIDs
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpConsignmentItem
  MessageDescriptor              Descriptor
  UInt32                         DownType
  UInt64                         InstID
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SellNum
  Int64                          SellPrice

## Msg.UpConsignmentItemAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateAlleviateAck
  MapField`2                     AlleviateMap
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateBattleScoreAck
  UInt32                         BattleScore
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.UpdateBitSignAck
  UInt32                         BitSign
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.UpdateBmsZhsAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Stage

## Msg.UpdateComboAck
  UInt32                         Combo
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateConsumeAck
  MessageDescriptor              Descriptor
  UInt32                         FixedItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RESET_COUNT_TYPE               ResetType
  UInt32                         RetCode
  UInt32                         TotalConsume

## Msg.UpdateDonotTouchMeTimeAck
  MessageDescriptor              Descriptor
  Int64                          DonotTouchMeTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.UpdateDoubleExpSignAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  Boolean                        IsOpen
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateDungeonCountAck
  FinishCondition                Condition
  MessageDescriptor              Descriptor
  UInt32                         DungeonID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateEffectSignAck
  MessageDescriptor              Descriptor
  UInt32                         EffectSign
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateEpithetAck
  MessageDescriptor              Descriptor
  EpithetNode                    EpithetData
  UInt32                         EpithetID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RemoveID
  UInt32                         RetCode

## Msg.UpdateEquipProficiencyAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     UpdateMaps

## Msg.UpdateFightAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Boolean                        SetFight

## Msg.UpdateFixedItemNumAck
  MessageDescriptor              Descriptor
  Int64                          Final
  UInt32                         FixedID
  OPERATE_TYPE                   Opt
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.UpdateHairstyleColorAck
  MessageDescriptor              Descriptor
  UInt32                         HairstyleColor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.UpdateIntimacyAck
  Int64                          AddValue
  MessageDescriptor              Descriptor
  Int64                          FinalValue
  UInt64                         FromID
  UInt32                         GuanXiType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TargetID

## Msg.UpdateLegionAssetAck
  Int64                          Change
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateLegionAuthorityAck
  UInt32                         Authority
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.UpdateLegionContributionAck
  UInt32                         Contribution
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateLegionGatherAck
  MessageDescriptor              Descriptor
  UInt32                         Gather
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.UpdateLegionGatherTypeAck
  MessageDescriptor              Descriptor
  LEGION_GATHER_TYPE             GatherType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateLegionGroupNameAck
  MessageDescriptor              Descriptor
  String                         GroupName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.UpdateLegionIdAck
  UInt32                         Authority
  MessageDescriptor              Descriptor
  String                         GroupName
  UInt64                         LegionID
  String                         LegionName
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.UpdateLegionLevelAck
  MessageDescriptor              Descriptor
  UInt64                         LegionID
  UInt32                         LegionLv
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateLegionNotifyReadTime
  MessageDescriptor              Descriptor
  UInt32                         NotifyType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          ReadTime

## Msg.UpdateLegionNotifyReadTimeAck
  MessageDescriptor              Descriptor
  UInt32                         NotifyType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          ReadTime
  UInt32                         RetCode

## Msg.UpdateLegionVoucherAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Voucher

## Msg.UpdateLockAndBindTimeAck
  Int64                          BindTime
  MessageDescriptor              Descriptor
  UInt64                         InstID
  Int64                          LockTime
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdatePlayerTeamIdAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  UInt64                         TeamID

## Msg.UpdateQixinxieliSignAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  Boolean                        IsOpen
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateQqzCsmAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  UInt32                         KillCount
  UInt32                         MaxKill
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Stage

## Msg.UpdateRankData
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RankType
  RankSort                       SetData

## Msg.UpdateRelationshipValueAck
  UInt32                         ChuShiCount
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateScreenGatherNumAck
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         ResCount
  UInt32                         RetCode

## Msg.UpdateSignValueAck
  UInt32                         CycleSignValue
  MessageDescriptor              Descriptor
  SignInNode                     MonthData
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateSkillInstAck
  MapField`2                     DataMap
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          StartUseSkillTime

## Msg.UpdateTalentSkillInstAck
  MapField`2                     DataMap
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          StartUseSkillTime

## Msg.UpdateTaskAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     Update

## Msg.UpdateTeamMembersAck
  UInt32                         Count
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         TeamID

## Msg.UpdateTemaMemberMapIdAck
  MessageDescriptor              Descriptor
  UInt32                         MapID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode

## Msg.UpdateTransportGoodsAck
  MessageDescriptor              Descriptor
  UInt32                         FallWater
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpdateVipBaseInfoAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         PlayerID
  UInt32                         RetCode
  VipBaseInfo                    VipBase

## Msg.UpdateVitalityAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt32                         Vitality
  MapField`2                     VitalityMap

## Msg.UpdateWelfareAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     WelfareMap

## Msg.UpdateYsSkillInstAck
  MapField`2                     DataMap
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  UInt64                         FromID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          StartUseSkillTime

## Msg.UpdateYueKaTimeAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int64                          YueKaTime

## Msg.UpgradeExpLegion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         UpgradeCount
  Boolean                        UseAsset

## Msg.UpgradeExpLegionAck
  UInt32                         Asset
  MessageDescriptor              Descriptor
  UInt32                         Exp
  UInt32                         Level
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpgradeLvLegion
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.UpgradeLvLegionAck
  UInt32                         Asset
  MessageDescriptor              Descriptor
  UInt32                         Exp
  UInt32                         Level
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpgradeResist
  MessageDescriptor              Descriptor
  Boolean                        IsUsePill
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Type
  UInt32                         UpgradeCount

## Msg.UpgradeResistAck
  UInt32                         AddedResist
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  ResistParam                    ResistParam
  UInt32                         RetCode

## Msg.UpJieBaiAttribLv
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt64                         TargetID

## Msg.UpJieBaiAttribLvAck
  MessageDescriptor              Descriptor
  UInt32                         NewConfigID
  UInt32                         OldConfigID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RemainingPoint
  UInt32                         RetCode
  UInt64                         TargetID

## Msg.UpMeridiansPoint
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Select

## Msg.UpMeridiansPointAck
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  UInt32                         NewConfigID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Remaining
  UInt32                         RetCode
  UInt32                         Select

## Msg.UpPractice
  UInt32                         ConfigID
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.UpPracticeAck
  UInt32                         ConfigID
  UInt32                         CurrentExp
  MessageDescriptor              Descriptor
  UInt32                         NewConfigID
  Int64                          NextUpTime
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UpSellSgd
  UInt32                         Amount
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          SellPrice

## Msg.UpSellSgdAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  SellSgdInfo                    SgdInfo
  UInt32                         UpCount

## Msg.UpSkillLevel
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SkillID

## Msg.UpSkillLevelAck
  MessageDescriptor              Descriptor
  UInt32                         OldSkillID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  MapField`2                     SettingMap
  UInt32                         SkillID

## Msg.UpStallsInfo
  MessageDescriptor              Descriptor
  UInt64                         InstID
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         SellNum
  Int64                          SellPrice

## Msg.UpStallsItem
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  String                         Shout
  RepeatedField`1                UpList

## Msg.UpStallsItemAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         StallsID

## Msg.UseBmsZhs
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.UseBmsZhsAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UseGate
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos

## Msg.UseGateAck
  Boolean                        ClientOpt
  MessageDescriptor              Descriptor
  UInt32                         LastMapID
  PixelsPos                      MovePos
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UseGateFinishNtfAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UseItem
  MessageDescriptor              Descriptor
  UInt64                         InstID
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UseItemParam                   UseParam

## Msg.UseItemAck
  MessageDescriptor              Descriptor
  UInt64                         InstID
  PACK_TYPE                      PackType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UseItemParamRet                UseRet

## Msg.UseItemParam
  Boolean                        BatchUse
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  RepeatedField`1                SelectItemID
  UInt64                         TargetID
  PixelsPos                      TargetPos
  Int32                          TransItemIndex
  Int64                          UseNum

## Msg.UseItemParamRet
  Boolean                        BatchUse
  Int64                          CoolDownTime
  MessageDescriptor              Descriptor
  Boolean                        IsSuccess
  UInt32                         ItemGroupID
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          PrivateTime
  String                         PrivateToken
  RepeatedField`1                SelectItemID

## Msg.UseMafaTranfer
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         TransferID

## Msg.UseNpcFunc
  BuyShopGoods                   BuyShop
  BeiMangShanDungeon             CreateBmsDungeon
  ChallengeDungeon               CreateDungeon
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  FinishTransportGoodsInfo       FinishTransport
  UInt32                         FuncID
  GetPlayerBaron                 GetBaron
  GetLegionGatherInfo            GetLegionGather
  GetQieCuoRecord                GetQieCuoRecord
  GetTransportGoodsInfo          GetTransportGoodsInfo
  OpenKlotskiChallenge           Klotski
  MerchantEntrust                MerchantTask
  OptWarehousePackage            OptPack
  OptPrivWarehouse               OptPrivatePack
  MessageParser`1                Parser
  PauseRingTask                  PauseTask
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  ResetRingTask                  ResetTask
  RestartRingTask                RestartTask
  StartJinXiu                    StartJinXiu
  StartXiaoLianQuestion          StartQuestion
  StartSubJobTask                StartSubJobTask
  SubParamOneofCase              SubParamCase
  UseMafaTranfer                 UseMafu

## Msg.UseNpcFuncAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.UseSkill
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 Direction
  UInt64                         FromID
  String                         NewKey
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         SkillID
  UInt64                         TargetID
  PixelsPos                      TargetPos
  String                         TestKey

## Msg.UseSkillAck
  Boolean                        AttackCooperate
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 Direction
  UInt64                         EntityID
  UInt64                         FromID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  UInt32                         RetCode
  UInt32                         SkillID
  Int64                          StartTime
  UInt64                         TargetID
  PixelsPos                      TargetPos

## Msg.VehiclesDeathAck
  MessageDescriptor              Descriptor
  DIRECTION_TYPE                 Direction
  UInt64                         EntityID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  PixelsPos                      Pos
  Int64                          RemoveBodyTime
  UInt32                         RetCode

## Msg.VipAllInfo
  MessageDescriptor              Descriptor
  UInt32                         Exp
  Boolean                        IsGetSVipAward
  Boolean                        IsGetVipAward
  UInt32                         Level
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          SVipExpireTime
  Int64                          VipExpireTime

## Msg.VipBaseInfo
  MessageDescriptor              Descriptor
  UInt32                         Exp
  UInt32                         Level
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int64                          SVipExpireTime
  Int64                          VipExpireTime

## Msg.VipMoveTo
  MessageDescriptor              Descriptor
  UInt64                         InstID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.VipMoveToAck
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.VitalityNode
  UInt32                         ClaimCount
  UInt32                         CurrCount
  MessageDescriptor              Descriptor
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.WearAppearance
  MessageDescriptor              Descriptor
  UInt64                         InstID
  Boolean                        IsUp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.WearAppearanceAck
  ItemData                       AppearanceData
  MessageDescriptor              Descriptor
  UInt64                         EntityID
  UInt64                         InstID
  Boolean                        IsUp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.WearEquip
  MessageDescriptor              Descriptor
  UInt64                         InstID
  Boolean                        IsUp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.WearEquipAck
  Int32                          AccumulatRate
  Int32                          AccumulatValue
  MessageDescriptor              Descriptor
  UInt64                         DownInstID
  UInt64                         EntityID
  ItemData                       EquipData
  Int32                          HpBase
  Int32                          HpScale
  UInt64                         InstID
  Boolean                        IsUp
  Int32                          JumpMax
  Int32                          MpBase
  Int32                          MpScale
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  Int32                          SpeedMax

## Msg.WearTalentBook
  MessageDescriptor              Descriptor
  UInt64                         InstID
  Boolean                        IsUp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  JOB_TALENT_TYPE                WearJob

## Msg.WearTalentBookAck
  MessageDescriptor              Descriptor
  UInt64                         InstID
  Boolean                        IsUp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  JOB_TALENT_TYPE                WearJob

## Msg.WelfareNode
  UInt32                         CurrCount
  MessageDescriptor              Descriptor
  UInt32                         NeedCount
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor

## Msg.YsAddExpNode
  Int64                          AddExp
  MessageDescriptor              Descriptor
  Int64                          FinalExp
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  ItemData                       YsData

## Msg.YsAttrib
  Int32                          AddCount
  Int32                          BaseID
  MessageDescriptor              Descriptor
  Int32                          GrowthAddCount
  Int32                          GrowthAddValue
  Int32                          GrowthID
  Int32                          GrowthValue
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  Int32                          Percent

## Msg.YsData
  MapField`2                     AttribMap
  UInt32                         BattleScore
  MessageDescriptor              Descriptor
  UInt32                         Energy
  Int64                          Exp
  MapField`2                     FuseMap
  UInt32                         Level
  UInt32                         LockLucky
  UInt32                         Loyalty
  UInt32                         Lucky
  String                         Name
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Quintessence
  UInt32                         RemainingCount
  Int64                          ResetGrowth
  UInt32                         Score
  ATTRIBUTE                      SiXiangType
  MapField`2                     SkillID
  MapField`2                     SpecialID
  UInt32                         UnlockLucky

## Msg.YsSkin
  MessageDescriptor              Descriptor
  UInt64                         InstID
  UInt32                         ItemID
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         Show

## Msg.YuanShenAddExpAck
  MapField`2                     AllMap
  MessageDescriptor              Descriptor
  OPERATE_TYPE                   ExpSource
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode

## Msg.YuanShenUpdateLoyaltyAck
  MessageDescriptor              Descriptor
  Int64                          FinalVal
  OPERATE_TYPE                   OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         YsInstID

## Msg.YuanShenUpdateLuckyAck
  MessageDescriptor              Descriptor
  Int64                          FinalVal
  OPERATE_TYPE                   OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         YsInstID

## Msg.YuanShenUpdateQuintessenceAck
  MessageDescriptor              Descriptor
  Int64                          FinalVal
  OPERATE_TYPE                   OptType
  MessageParser`1                Parser
  MessageDescriptor              pb::Google.Protobuf.IMessage.Descriptor
  UInt32                         RetCode
  UInt64                         YsInstID

---
# 消息 ID (MsgId*)

## MsgIdCsReflection  (IsEnum=False)
   (非常量)  descriptor

## MsgIdSsReflection  (IsEnum=False)
   (非常量)  descriptor

## MsgIdWebReflection  (IsEnum=False)
   (非常量)  descriptor

---
# 网络请求方法

- AddNotifyLegionAck.get_NotifyType()
- AddNotifyLegionAck.set_NotifyType(UInt32 value)
- AllTeamData.RequestApplyForList(ApplyAddTeamNtfAck applyAddTeamNtf)
- AllTeamData.RequestApplyForList(OptApplyTeamAck optApplyTeamAck)
- AllTeamData.RequestApplyForList(SendTeamBrieflyAck sendTeamBrieflyAck)
- AllTeamData.RequestBeInvitationList(OptTeamSendInviteOtherAck optTeamSendApplyNtf)
- AllTeamData.RequestSummonList(CallMembersTeamAck callMembersBackAck)
- AllTeamData.RequestTeamData(CreatTeamAck creatTeamAck)
- AllTeamData.RequestTeamData(GetTeamListAck getTeamListAck)
- AllTeamData.RequestTeamData(OptTeamExitAck optTeamExitAck)
- ApplicationManager.OnAtlasRequested(String tag, Action`1 callback)
- BattleModule.OnDeathNotify(Byte[] buffer)
- BattleModule.RequestGetGatherAward()
- BattleModule.RequestGetGatherAwardAck(Byte[] buffer)
- BattleModule.RequestMoveToPos()
- BattleModule.RequestPickupItem(List`1 pickList)
- BattleModule.RequestPickupItem(UInt64 pickID)
- BattleModule.RequestSetAttackMode(UInt32 attackMode)
- BattleModule.RequestSetStatus(ENTITY_STATUS status)
- BattleModule.RequestStartGather(UInt64 entityID, Vector2 pos, DIRECTION_TYPE directionType)
- BattleModule.RequestStartGatherAck(Byte[] buffer)
- BattleModule.RequestStopGather()
- BattleModule.RequestStopGatherAck(Byte[] buffer)
- BattleScene.RegisterEntity(EEntityType eEntityType, Transform transform)
- CfgGlobal.get_FriendRequestMaxSize()
- CfgGlobal.get_RegisterMailCodeCd()
- CharacterEntity.OnNotifyPkValueEvent(Object[] aObject)
- CharacterEntity.RequestAppearance(Object[] obj)
- CharacterFsmStateBase.RequestCharacterJump(Object[] args)
- ChatData.RequestChatData(GetChatListAck getChatListAck)
- ChatData.RequestChatData(SendChatAck sendChatAck)
- ChatData.RequestChatData(SendChatMessageAck sendChatNtfAck)
- ChatData.RequestLastReadNum(SetChatLastReadNumAck setChatLastReadNumAck)
- Develop.RegisterMessageHandler(MessageParser`1 oMessageParser, MSGID2CS eMsg, Action`1 callBack, Boolean errorIsCallBack)
- DoubleExpModule.RequestGetDailyDoubleExpTime()
- DoubleExpModule.RequestPauseDoubleExp()
- DoubleExpModule.RequestPauseQixinxieli()
- DoubleExpModule.RequestRestartDoubleExp()
- DoubleExpModule.RequestRestartQixinxieli()
- EpithetModule.RequestGetEpithet()
- EpithetModule.RequestSetEpithet(UInt32 epithetID, UInt64 targetId, SET_TYPE setType)
- EquipMadeModule.RequestData(Object[] obj)
- ExchangeModule.RequestApplyTrade(UInt64 targetID)
- ExchangeModule.RequestApplyTradeList(Object[] obj)
- ExchangeModule.RequestCancelTrade(Boolean isLock)
- ExchangeModule.RequestConfirmTrade(Int64 time, String sign)
- ExchangeModule.RequestLockTrade()
- ExchangeModule.RequestOptApplyTrade(UInt64 applyID, Boolean isAgree, Int64 limitTime, String sign)
- ExtToggle.SetSelectedIndexWithoutNotify(Int32 index)
- ForwardLegionMsg.get_NotifyData()
- ForwardLegionMsg.set_NotifyData(ByteString value)
- ForwardMsgNotif.get_NotifyData()
- ForwardMsgNotif.set_NotifyData(ByteString value)
- FriendModule.RequestApplyAddFriend(String playerName, GUAN_XI_TYPE type)
- FriendModule.RequestApplyAddFriend(UInt64 targetID, GUAN_XI_TYPE type)
- FriendModule.RequestChangeBlackList(Boolean isAdd, UInt64 targetID)
- FriendModule.RequestDelFriend(UInt64 targetID, GUAN_XI_TYPE type)
- FriendModule.RequestGetApplyFriendList(Boolean isRead)
- FriendModule.RequestGetBlacklist()
- FriendModule.RequestOptApplyFriend(UInt64 applyID, Boolean isAgree, GUAN_XI_TYPE type)
- FriendModule.RequestOptSummonFriend(Boolean isAgree, UInt64 targetID, UInt32 lineID, UInt32 mapID, PixelsPos pos, Int64 limitTime, String sign)
- FriendModule.RequestSummonFriend(UInt64 targetID)
- FriendModule.RequestSummonList(Object[] obj)
- GameGlobalSetting.GetLoginUrl()
- GameTestingSocket.<CloseSocket>b__48_0()
- GameTestingSocket.CloseSocket(Boolean isInitiative)
- GameTestingSocket.Connect()
- GameTestingSocket.ConnectSocket()
- GameTestingSocket.get_OnSocketConnectClose()
- GameTestingSocket.get_OnSocketConnectSuccess()
- GameTestingSocket.get_OnSocketError()
- GameTestingSocket.get_OnSocketReceiveMessage()
- GameTestingSocket.GetGameTestingSocketType()
- GameTestingSocket.ReConnect(String ip, Int32 port)
- GameTestingSocket.set_OnSocketConnectClose(Action`1 value)
- GameTestingSocket.set_OnSocketConnectSuccess(Action`1 value)
- GameTestingSocket.set_OnSocketError(Action`1 value)
- GameTestingSocket.set_OnSocketReceiveMessage(Action`3 value)
- GateEntity.RequestUseGate(GateEntityData gateEntityData)
- GetGiveGiftListAck.get_LoginDays()
- GetGiveGiftListAck.set_LoginDays(UInt32 value)
- GetLegionBaseAck.get_IsLogin()
- GetLegionBaseAck.set_IsLogin(Boolean value)
- GetNotifyLegionAck.get_LastNotifyTime()
- GetNotifyLegionAck.set_LastNotifyTime(Int64 value)
- GmCommand.RequestGmTestDrop(String[] obj)
- HallAllFuncPortModule.RequestGetAllLine(UInt64 playerID)
- HallAllFuncPortModule.RequestGetFuncPortSetting()
- HallAllFuncPortModule.RequestGetSwitchLine(UInt32 lineID)
- HallAllFuncPortModule.RequestSetFuncPortSetting(String settingData, Boolean isInitiative)
- HallModule.OnKillNotify(Byte[] buffer)
- LegionData.AddNotifyLegionAckDataProcessing(AddNotifyLegionAck data)
- LegionData.get_IsNotifyRead()
- LegionData.get_LastNotifyTime()
- LegionData.GetEventNotifyLegionAckDataProcessing(GetEventNotifyLegionAck data)
- LegionData.GetNotifyLegionAckDataProcessing(GetNotifyLegionAck data)
- LegionData.NotifyLegionFight()
- LegionData.NotifyLegionFightReady(Boolean force)
- LegionData.set_IsNotifyRead(Boolean value)
- LegionData.set_LastNotifyTime(Int64 value)
- LegionData.SetNotifyRead(Int32 index)
- LegionModule.AddNotifyLegionAck(Byte[] buffer)
- LegionModule.GetEventNotifyLegion()
- LegionModule.GetEventNotifyLegionAck(Byte[] buffer)
- LegionModule.GetNotifyLegion()
- LegionModule.GetNotifyLegionAck(Byte[] buffer)
- LegionModule.ModifyNotifyLegion(UInt64 removeID, String Notify)
- LegionModule.ModifyNotifyLegionAck(Byte[] buffer)
- LegionModule.RequestApproveApplyLegion(UInt64 targetID, Boolean agree)
- LegionModule.RequestGetApplyListLegion()
- LegionModule.RequestGetChangeMemberLegion()
- LegionModule.RequestGetLegionGatherInfo()
- LegionModule.RequestGetLegionMember()
- LegionModule.RequestGetLegionMonthly()
- LegionModule.RequestInviteLegion(UInt64 targetID)
- LegionModule.RequestKickLegion(UInt64 targetID)
- LegionModule.RequestLeaveLegion()
- LegionModule.RequestModifyGroupNameLegion(UInt32 groupID, String groupName)
- LegionModule.RequestModifyViceAuthorityLegion(UInt64 targetID, UInt32 authority)
- LegionModule.RequestOptInviteLegion(UInt64 legionID, UInt64 inviteID, Int64 inviteTime, String sign, Boolean agree)
- LegionModule.RequestSetGroupLegion(UInt32 groupID, List`1 list)
- LegionModule.RequestSetManifestoLegion(String str, Boolean isAuto)
- LegionModule.RequestSetViceLegion(UInt64 targetID, Boolean isAdd)
- LegionModule.RequestTransferLeaderLegion(UInt64 targetID)
- LegionModule.UpdateLegionNotifyReadTime(UInt32 notifyType, Int64 readTime)
- LegionModule.UpdateLegionNotifyReadTimeAck(Byte[] buffer)
- LoginAwardData.get_LoginDays()
- LoginAwardData.set_LoginDays(UInt32 value)
- LoginData.get_LoginRegionDatas()
- LoginData.set_LoginRegionDatas(List`1 value)
- LoginData.UpdateLoginRegionList(GetAllRegionAck regionAck)
- LoginData.UpdateLoginRegionList(List`1 regionList)
- LoginData.UpdateLoginRoleList(GetAllPlayerAck allPlayerAck)
- LoginData.UpdateLoginRoleList(List`1 regionRoleList)
- LoginModule.AccountLogin()
- LoginModule.AccountLoginAck(Byte[] bytes)
- LoginModule.BreakReconnectionFail(Object[] obj)
- LoginModule.BreakReconnectionSucceed(Object[] obj)
- LoginModule.get_LoginRegionID()
- LoginModule.GetRegionLoginServer(UInt32 regionID)
- LoginModule.GetRegionLoginServerAck(Byte[] buffer)
- LoginModule.HttpLogin(Boolean force)
- LoginModule.OnHallSocketConnectSuccess(Object[] obj)
- LoginModule.PostWebRequest(String sUrl, Object data, Action`1 success, Action`1 error)
- LoginModule.RegionLoginServer(UInt32 regionId)
- LoginModule.RequestAccountLogin(Object[] obj)
- LoginModule.RequestChangingAccountPassword(String accountStr, String oldPassStr, String newPassStr, String confirmStr, Boolean isSaveAccount)
- LoginModule.RequestGraphicCode()
- LoginModule.RequestHallList()
- LoginModule.RequestHallRoles()
- LoginModule.RequestLoginAccount(String accountStr, String passwordStr, Boolean isSaveAccount)
- LoginModule.RequestLoginNotice()
- LoginModule.RequestNotice()
- LoginModule.RequestRegisterAccount(String accountStr, String passwordStr, String verificationCode, String inviteCodeStr, String bindCodeStr)
- LoginModule.RequestResetPwd(String accountStr, String emailCode, String newPassStr, String confirmStr, Boolean isSaveAccount)
- LoginModule.RequestServerTime(Object[] args)
- LoginModule.RequestToken()
- LoginModule.RequestVerificationCode(String graphCode, String email)
- LoginModule.ServerDisconnectAck(Byte[] bytes)
- LoginRegionRoleData.get_LastLoginTime()
- LoginRegister.RequestLoginAccount(Int32 index, String userName, String ipStr, String token)
- LoginRegister.RequestRegisterAccount(Int32 index, String token)
- LoginRegister.RequestToken(Int32 index)
- MailModule.RequestDeleteMail(UInt64 mailInstID)
- MailModule.RequestDeleteMailAck(Byte[] bytes)
- MailModule.RequestGetMailList()
- MailModule.RequestSetReadMail(UInt64 mailInstID)
- ModifyNotifyLegion.get_Notify()
- ModifyNotifyLegion.set_Notify(String value)
- ModifyNotifyLegionAck.get_Notify()
- ModifyNotifyLegionAck.set_Notify(String value)
- NetworkManager.CloseHallSocket()
- NetworkManager.ConnectHallSocket(String ip, Int32 port, SocketHandlerType socketHandlerType)
- NetworkManager.InitiativeCloseSocket(String ip, Int32 port, SocketHandlerType socketHandlerType)
- NetworkManager.OnSocketConnectClose(SocketHandler handler)
- NetworkManager.OnSocketConnectSuccess(SocketHandler handler)
- NetworkManager.OnSocketError(SocketHandler handler)
- NetworkManager.RegisterMessageHandler(MSGID2CS msgID, NetworkReceiveCallBack callBack, Boolean errorIsCallBack)
- NewPlayerGuideModule.RequestGuideData(Object[] obj)
- NewPlayerGuideModule.RequestGuideID(Object[] obj)
- NpcFuncHandle.RequestManualOpenLegionParty(CfgNpcFunc cfgNpcFunc, UInt64 npcEntityID)
- NpcFuncHandle.RequestRandomLegionGatherNum(CfgNpcFunc cfgNpcFunc, UInt64 npcEntityID)
- NpcFuncHandle.RequestSubmitLegionGather(CfgNpcFunc cfgNpcFunc, UInt64 npcEntityID)
- PackageModule.OnNotifyPkValueEvent(Byte[] buffer)
- PayShopModule.RequestBuySanGuoDian(UInt32 channelID, UInt32 configID, PAY_FUNC_TYPE type)
- PayShopModule.RequestBuySanGuoDian(UInt32 iCfgItemId, UInt32 iCount)
- PayShopModule.RequestClaimShopScoreConsumeReward(UInt32 configID, UInt32 amount)
- PlayerModule.RequestCancelDeletePlayer(CancelDeletePlayer cancelDelete)
- PlayerModule.RequestCreateRole(CreatePlayer roleInfo)
- PlayerModule.RequestDeletePlayer(DeletePlayer deletePlayer)
- PlayerNode.get_LastLogin()
- PlayerNode.set_LastLogin(Int64 value)
- PlayerSelf.get_LastLogin()
- PlayerSelf.set_LastLogin(Int64 value)
- QuestionModule.RequestCheckAnswer(UInt32 questionID, UInt32 answerID)
- QuestionModule.RequestQuitQuestion()
- QuestionModule.RequestResetQuestion(UInt32 questionID, UInt32 answerID)
- QuestionModule.RequestTwistedEggLottery(TWISTED_EGG_TYPE drawType)
- RankModule.RequestRankData(RANK_TYPE rankType, Boolean isToday)
- RankModule.RequestRankDataAck(Byte[] buffer)
- RedPointManager.RegisterNode(String nodeName, GameObject redGo)
- RedPointManager.UnRegisterRedNode(String nodeName, GameObject redGo)
- SecurityBindingModule.RequestBindInviteCode(String inviteCode)
- SecurityBindingModule.RequestSecurityInfoBind(String nameStr, String telephoneNumberStr, String emailStr, String identificationCardStr, String securityCode)
- ShopModule.RequestGetGoodsList(UInt32 shopID)
- ShukuchiRuneModule.LoginRequest(Object[] objects)
- SkillModule.RequestGetPlayerSkill()
- SkillModule.RequestGetResistList()
- SkillModule.RequestGetSkillSetting()
- SkillModule.RequestUpgradeResist(UpgradeResist upgradeResist)
- SkillModule.RequestUseSkill(UInt32 skillID, DIRECTION_TYPE directionType, PixelsPos playerPos, PixelsPos targetPos, UInt64 entityID, UInt64 insId)
- SkillScheme.get_Sockets()
- SkillSystemData.RequestUseSkill(SkillData skillData, Boolean isTips)
- SkillSystemData.RequestUseSkill(UInt32 skillID, UInt64 insId)
- SocketHandler.<CloseSocket>b__50_0()
- SocketHandler.<ConnectSocket>b__42_0()
- SocketHandler.CheckIsNeedIsReconnect()
- SocketHandler.CloseSocket(Boolean isInitiative)
- SocketHandler.Connect()
- SocketHandler.ConnectSocket()
- SocketHandler.get_OnSocketConnectClose()
- SocketHandler.get_OnSocketConnectSuccess()
- SocketHandler.get_OnSocketError()
- SocketHandler.GetSocketHandlerType()
- SocketHandler.set_OnSocketConnectClose(Action`1 value)
- SocketHandler.set_OnSocketConnectSuccess(Action`1 value)
- SocketHandler.set_OnSocketError(Action`1 value)
- SocketHandler.StartReconnect()
- SocketManager.Connect()
- SocketManager.OnSocketConnectClose(GameTestingSocket socketHandler, Int32 id)
- SocketManager.OnSocketConnectSuccess(GameTestingSocket socketHandler, Int32 id)
- SocketManager.OnSocketError(GameTestingSocket socketHandler, Int32 id)
- SocketManager.OnSocketReceiveMessage(GameTestingSocket socketHandler, MSGID2CS msgId, Byte[] bytes)
- StallData.RequestStall()
- TaskModule.RequestAbandonTask(UInt32 id)
- TaskModule.RequestAddCommissionedTask(UInt64 publishID)
- TaskModule.RequestClaimTaskAward(UInt32 taskID)
- TaskModule.RequestCommissionedCompose(UInt32 itemID, UInt32 index, UInt32 count)
- TaskModule.RequestGetCommissionedTask()
- TaskModule.RequestGetOneTask(UInt32 id, Boolean isGetOne, Boolean isTraceNoLevel, Boolean isUseTicket)
- TaskModule.RequestGetTaskAward(UInt32 id)
- TaskModule.RequestGetTaskList()
- TaskModule.RequestNpcChatComplete(UInt32 npcID, UInt32 taskID)
- TaskModule.RequestPublishTask(UInt64 itemInstID)
- TaskModule.RequestSetTaskFollow(UInt32 id, Boolean isFollow)
- TeamModule.RequestSummonList(Object[] obj)
- TeamModule.RequestTeamList(Object[] obj)
- UIAccountInput.OnRegisterButtonClick()
- UIAccountRegister.SetRegisterButtonStatus()
- UIApplySummonItem.RequestCountdown(Object[] obj)
- UIBattleTarget.RequestLv(Object[] obj)
- UIChatEmoji.RequestEmojiLoop(TabType type)
- UIChatParticularsShow.RequestInfo()
- UIChatParticularsShow.RequestPrivateChatList()
- UIChatParticularsShow.RequestPrivateChatShow(Object[] obj)
- UIChatParticularsShow.RequestRed(CHAT_CHANNEL type)
- UIChatParticularsShow.RequestShow(Object[] obj)
- UIChatParticularsShow.RequestTeamInfo(Object[] obj)
- UIChatParticularsShow.RequestTeamList(Boolean isChange)
- UIChatSimplenessShow.RequestInitShow(Object[] args)
- UIChatSimplenessShow.RequestSpecialPrivateShow(Object[] obj)
- UIChatSimplenessShow.RequestSystemInfoShow(Object[] obj)
- UIConfirmTip.RequestType(UIConfirmTipTypeEnum nowType)
- UIDungeonCompleteMain.RequestTimeShow(Object[] obj)
- UIDungeonCountryBattle.RequestBattleDetail()
- UIDungeonCountryBattle.RequestEndTime(Object[] obj)
- UIDungeonCountryBattle.RequestRankData()
- UIDungeonInfoMain.RequestEndTime(Object[] obj)
- UIDungeonInfoMain.RequestShow(Object[] obj)
- UIEquiphole.RequestData(Queue`1 queue)
- UIEquipInlay.RequestData(Queue`1 queue)
- UIEquipInlay.RequestGemGroup()
- UIEquipRepair.RequestList(Object[] obj)
- UIEquipResetRemake.RequestData(Queue`1 datas)
- UIEquipSiXiang.RequestData(Queue`1 datas)
- UIEquipstrengthen.RequestData(Queue`1 queue)
- UIEquipUpgradeMain.RequestData(Object[] arg)
- UIEquipUpgradeMain.RequestPropList(Object[] arg)
- UIEquipUpgradeTab.RequestData(Queue`1 queue)
- UIFightCountry.OnNotifyCountrySign(Object[] args)
- UIFriendBase.get_ForceRequest()
- UIFriendBase.set_ForceRequest(Boolean value)
- UIFriendItem.RequestSummonFriend()
- UIFriendTeam.RequestList(Boolean isChangePos)
- UIFriendTeam.RequestTeamList(Object[] obj)
- UIGameMessageTip.RequestQuickUseShow(Object[] args)
- UIHall.OnPVPNotify()
- UIHall.RequestInfo(CHAT_CHANNEL type)
- UIHall.RequestInitShow(Object[] args)
- UIHall.RequestRed(CHAT_CHANNEL type)
- UIHall.RequestShow(Object[] obj)
- UIHallBattle.RequestDecreaseHpCurrentList(Object[] args)
- UIHallBattle.RequestQuickUseShow(Object[] args)
- UIHallBattle.RequestUseSkill(SkillData skillData)
- UIHallMiniMap.RequestMinMapShow(Object[] obj)
- UIHallPropHpRevertMain.RequestShow(Object[] args)
- UIHallTeamPopWindow.RequestShow(Object[] obj)
- UIHallTipsStatus.<OnNotifyCountryBattle>b__34_0()
- UIHallTipsStatus.<OnNotifyCountrySign>b__35_0()
- UIHallTipsStatus.<OnNotifyLegionFightBattle>b__13_0()
- UIHallTipsStatus.<OnNotifyLegionFightSign>b__14_0()
- UIHallTipsStatus.<OnNotifyPvpBattle>b__17_2()
- UIHallTipsStatus.<OnNotifyTeamBattle>b__15_2()
- UIHallTipsStatus.OnNotifyCountryBattle(Object[] objs)
- UIHallTipsStatus.OnNotifyCountrySign(Object[] objs)
- UIHallTipsStatus.OnNotifyLegionFightBattle(Object[] objs)
- UIHallTipsStatus.OnNotifyLegionFightSign(Object[] objs)
- UIHallTipsStatus.OnNotifyPvpBattle(Object[] objs)
- UIHallTipsStatus.OnNotifyTeamBattle(Object[] objs)
- UIHaveTeamHallState.RequestAddPlayerInfo(Object[] obj)
- UIHaveTeamHallState.RequestDeletePlayerInfo(Object[] obj)
- UIHaveTeamHallState.RequestList()
- UIHaveTeamHallState.RequestShow(Object[] obj)
- UILoginMain.OnRefreshLoginMain(Object[] args)
- UILoginMain.RequestAccountLogin(Object[] obj)
- UILoginMain.RequestSessionAccount()
- UIMiniMap.RequestPathfindingItem(Object[] obj)
- UIOtherPlayerOperation.RequestShow(Object[] objects)
- UIOtherPlayerOperation.RequestSummonFriend(UInt64 playerID)
- UIPackageCharacter.RequestItemInfo()
- UIPlayerEquipMain.RequestItemInfo()
- UIPlayerInfoMain.RequestView(Object[] args)
- UIPlayerStateInfo.RequestData(PlayerBase playerBase, MapField`2 attributeMap)
- UIPrefab.RegisterNode(String nodeName, GameObject redGo)
- UIPrefab.UnRegisterRedNode()
- UIPrivateChatExpression.RequestEmojiLoop(TabType type)
- UIPrivateChatItem.RequestData(Object date)
- UIPrivateChatList.RequestPrivateChatShow(Object[] obj)
- UIPrivateChatMain.RequestShow(Object[] obj)
- UIPrivateChatOtherInfo.RequestShow(Object[] obj)
- UIQuickCompleteTip.RequestItemUseCount()
- UIQuickUsePropItem.<RequestDate>b__15_0(Object[] x)
- UIQuickUsePropItem.RequestDate(PropData propData)
- UIRankMain.RequestCurrencyShowRankData()
- UIRegisterSuccess.JumpLogin()
- UIRegisterSuccess.OnSaveAndLoginButtonClick()
- UIRegisterSuccess.OnToLoginButtonClick()
- UIRoleSelect.RequestEnterMap(Object[] obj)
- UISkillMain.RequestGrid(Int32 index, Boolean isInitState)
- UIStallDetail.OnRequestHyperlinkDataSucceed(Object[] objs)
- UISummonList.RequestInvitation(Object[] obj)
- UISummonList.RequestInvitationList(Boolean isChangePos)
- UISummonList.RequestSummon(Object[] obj)
- UISummonList.RequestSummonList(Boolean isChangePos)
- UISystemSetting.BackLogin()
- UISystemSetting.RequestUseCode(String codeStr)
- UITeamApplyList.RequestList(Boolean isChangePos)
- UITeamApplyList.RequestList(Object[] obj)
- UITeamCreate.RequestLoopList(TabType type, Boolean isChangePos)
- UITeamHall.RequestList(Boolean isChangePos)
- UITeamHall.RequestTeamList(Object[] obj)
- UITeamInviteList.RequestList(Object[] obj)
- UITeamMain.RequestAllPlayerBase(SingleTeamData singleTeamData)
- UITeamMain.RequestCountDown(Object[] obj)
- UITeamMain.RequestInfo(Object[] obj)
- UITeamMain.RequestList(Object[] obj)
- UITeamMain.RequestPlayerAppearance(Object[] obj)
- UITeamMain.RequestShow(Object[] obj)
- UITransportGoods.RequestNeedPropNum(Object[] obj)
- UITransportGoods.RequestShow(Object[] obj)
- UIYuanshenMain.RequestSetYsShowAppear()
- UIYuanshenMain.RequestSetYsShowType(YS_SHOW type)
- UpdateLegionNotifyReadTime.get_NotifyType()
- UpdateLegionNotifyReadTime.set_NotifyType(UInt32 value)
- UpdateLegionNotifyReadTimeAck.get_NotifyType()
- UpdateLegionNotifyReadTimeAck.set_NotifyType(UInt32 value)
- VipModule.RequestClaimVipReward(Boolean isSVip)
- VipModule.RequestGetVipInfo()
- WarehouseModule.RequestOptPrivateWarehousePackage(OptPrivWarehouse optPrivateWarehousePackage)
- WarehouseModule.RequestOptWarehousePackage(OptWarehousePackage optWarehousePackage)
- WarehouseModule.RequestUseNpcFunc(UInt64 entityID, CfgNpcFunc cfgNpcFunc, OptPrivWarehouse optPrivateWarehousePackage)
- WarehouseModule.RequestUseNpcFunc(UInt64 entityID, CfgNpcFunc cfgNpcFunc, OptWarehousePackage optWarehousePackage)
- WarehouseModule.RequestUseNpcFunc(UseNpcFunc ack)
- YuanShenModule.RequestActiviGhost(UInt32 configID)
- YuanShenModule.RequestActiviYuanShen(UInt64 insId, Boolean processed)
- YuanShenModule.RequestChangeYsName(UInt64 ysInsId, String newName)
- YuanShenModule.RequestChangeYsUpGrade(UInt64 ysInsId, UInt32 configID, Dictionary`2 skills, Boolean keepFuse, Boolean keepLv)
