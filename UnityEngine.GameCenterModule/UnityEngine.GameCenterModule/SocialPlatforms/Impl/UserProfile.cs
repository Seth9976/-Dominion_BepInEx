using System;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x02000010 RID: 16
	public class UserProfile
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002223 File Offset: 0x00000423
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002230 File Offset: 0x00000430
		public void SetUserName(string name)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000223D File Offset: 0x0000043D
		public void SetUserID(string id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000224A File Offset: 0x0000044A
		public void SetLegacyUserID(string id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002257 File Offset: 0x00000457
		public void SetUserGameID(string id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002264 File Offset: 0x00000464
		public void SetImage(Texture2D image)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002271 File Offset: 0x00000471
		public void SetIsFriend(bool value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000227E File Offset: 0x0000047E
		public void SetState(UserState state)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000228B File Offset: 0x0000048B
		public string userName
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002298 File Offset: 0x00000498
		public string id
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000022A5 File Offset: 0x000004A5
		public string legacyId
		{
			get
			{
				throw new NotSupportedException("legacyId returns playerID from GKPlayer, which became obsolete in iOS 12.4 . id returns playerID for devices running versions before iOS 12.4, and the newer teamPlayerID for later versions. Please use IUserProfile.id or UserProfile.id instead");
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000022B2 File Offset: 0x000004B2
		public string gameId
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000022BF File Offset: 0x000004BF
		public bool isFriend
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000022CC File Offset: 0x000004CC
		public UserState state
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000022D9 File Offset: 0x000004D9
		public Texture2D image
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0400000E RID: 14
		public const string legacyIdObsoleteMessage = "legacyId returns playerID from GKPlayer, which became obsolete in iOS 12.4 . id returns playerID for devices running versions before iOS 12.4, and the newer teamPlayerID for later versions. Please use IUserProfile.id or UserProfile.id instead";
	}
}
