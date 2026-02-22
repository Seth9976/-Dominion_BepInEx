using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x0200000F RID: 15
	public class LocalUser : UserProfile
	{
		// Token: 0x06000025 RID: 37 RVA: 0x000021B5 File Offset: 0x000003B5
		public void Authenticate(Action<bool> callback)
		{
			ActivePlatform.Instance.Authenticate(this, callback);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000021C5 File Offset: 0x000003C5
		public void LoadFriends(Action<bool> callback)
		{
			ActivePlatform.Instance.LoadFriends(this, callback);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000021D5 File Offset: 0x000003D5
		public void SetFriends(Il2CppReferenceArray<IUserProfile> friends)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000021E2 File Offset: 0x000003E2
		public void SetAuthenticated(bool value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000021EF File Offset: 0x000003EF
		public void SetUnderage(bool value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000021FC File Offset: 0x000003FC
		public Il2CppReferenceArray<IUserProfile> friends
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002209 File Offset: 0x00000409
		public bool authenticated
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002216 File Offset: 0x00000416
		public bool underage
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
