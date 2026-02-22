using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x020002C5 RID: 709
	public static class PlayableOutputExtensions
	{
		// Token: 0x0600221F RID: 8735 RVA: 0x0006A3B0 File Offset: 0x000685B0
		public static bool IsOutputNull<U>(U output) where U : struct
		{
			return output.GetHandle().IsNull();
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x0006A3D8 File Offset: 0x000685D8
		public static bool IsOutputValid<U>(U output) where U : struct
		{
			return output.GetHandle().IsValid();
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x0006A400 File Offset: 0x00068600
		public static Object GetReferenceObject<U>(U output) where U : struct
		{
			return output.GetHandle().GetReferenceObject();
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x0006A428 File Offset: 0x00068628
		public static void SetReferenceObject<U>(U output, Object value) where U : struct
		{
			output.GetHandle().SetReferenceObject(value);
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x0006A450 File Offset: 0x00068650
		public static Object GetUserData<U>(U output) where U : struct
		{
			return output.GetHandle().GetUserData();
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x0006A478 File Offset: 0x00068678
		public static void SetUserData<U>(U output, Object value) where U : struct
		{
			output.GetHandle().SetUserData(value);
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x0006A4A0 File Offset: 0x000686A0
		public static Playable GetSourcePlayable<U>(U output) where U : struct
		{
			return new Playable(output.GetHandle().GetSourcePlayable());
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x0006A4CC File Offset: 0x000686CC
		public static void SetSourcePlayable<U, V>(U output, V value) where U : struct where V : struct
		{
			output.GetHandle().SetSourcePlayable(value.GetHandle(), PlayableOutputExtensions.GetSourceOutputPort<U>(output));
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x0006A504 File Offset: 0x00068704
		public static void SetSourcePlayable<U, V>(U output, V value, int port) where U : struct where V : struct
		{
			output.GetHandle().SetSourcePlayable(value.GetHandle(), port);
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0006A538 File Offset: 0x00068738
		public static int GetSourceOutputPort<U>(U output) where U : struct
		{
			return output.GetHandle().GetSourceOutputPort();
		}

		// Token: 0x06002229 RID: 8745 RVA: 0x0006A560 File Offset: 0x00068760
		public static float GetWeight<U>(U output) where U : struct
		{
			return output.GetHandle().GetWeight();
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x0006A588 File Offset: 0x00068788
		public static void SetWeight<U>(U output, float value) where U : struct
		{
			output.GetHandle().SetWeight(value);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x0006A5B0 File Offset: 0x000687B0
		public static void PushNotification<U>(U output, Playable origin, INotification notification, [Optional] Object context) where U : struct
		{
			output.GetHandle().PushNotification(origin.GetHandle(), notification, context);
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x0006A5E0 File Offset: 0x000687E0
		public static Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers<U>(U output) where U : struct
		{
			return output.GetHandle().GetNotificationReceivers();
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x0006A608 File Offset: 0x00068808
		public static void AddNotificationReceiver<U>(U output, INotificationReceiver receiver) where U : struct
		{
			output.GetHandle().AddNotificationReceiver(receiver);
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x0006A630 File Offset: 0x00068830
		public static void RemoveNotificationReceiver<U>(U output, INotificationReceiver receiver) where U : struct
		{
			output.GetHandle().RemoveNotificationReceiver(receiver);
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x0006A658 File Offset: 0x00068858
		public static int GetSourceInputPort<U>(U output) where U : struct
		{
			return output.GetHandle().GetSourceOutputPort();
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x00014274 File Offset: 0x00012474
		public static void SetSourceInputPort<U>(U output, int value) where U : struct
		{
			PlayableOutputExtensions.SetSourcePlayable<U, Playable>(output, PlayableOutputExtensions.GetSourcePlayable<U>(output), value);
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00014285 File Offset: 0x00012485
		public static void SetSourceOutputPort<U>(U output, int value) where U : struct
		{
			PlayableOutputExtensions.SetSourcePlayable<U, Playable>(output, PlayableOutputExtensions.GetSourcePlayable<U>(output), value);
		}
	}
}
