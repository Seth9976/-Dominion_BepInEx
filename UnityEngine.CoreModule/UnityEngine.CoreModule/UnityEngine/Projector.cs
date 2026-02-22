using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020001F2 RID: 498
	public sealed class Projector : Behaviour
	{
		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x000114AA File Offset: 0x0000F6AA
		// (set) Token: 0x06001E72 RID: 7794 RVA: 0x000114BC File Offset: 0x0000F6BC
		public float nearClipPlane
		{
			get
			{
				return Projector.get_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x000114CF File Offset: 0x0000F6CF
		// (set) Token: 0x06001E74 RID: 7796 RVA: 0x000114E1 File Offset: 0x0000F6E1
		public float farClipPlane
		{
			get
			{
				return Projector.get_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x000114F4 File Offset: 0x0000F6F4
		// (set) Token: 0x06001E76 RID: 7798 RVA: 0x00011506 File Offset: 0x0000F706
		public float fieldOfView
		{
			get
			{
				return Projector.get_fieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_fieldOfViewDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x00011519 File Offset: 0x0000F719
		// (set) Token: 0x06001E78 RID: 7800 RVA: 0x0001152B File Offset: 0x0000F72B
		public float aspectRatio
		{
			get
			{
				return Projector.get_aspectRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_aspectRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x0001153E File Offset: 0x0000F73E
		// (set) Token: 0x06001E7A RID: 7802 RVA: 0x00011550 File Offset: 0x0000F750
		public bool orthographic
		{
			get
			{
				return Projector.get_orthographicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_orthographicDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00011563 File Offset: 0x0000F763
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x00011575 File Offset: 0x0000F775
		public float orthographicSize
		{
			get
			{
				return Projector.get_orthographicSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_orthographicSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x00011588 File Offset: 0x0000F788
		// (set) Token: 0x06001E7E RID: 7806 RVA: 0x0001159A File Offset: 0x0000F79A
		public int ignoreLayers
		{
			get
			{
				return Projector.get_ignoreLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				Projector.set_ignoreLayersDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x000647D4 File Offset: 0x000629D4
		// (set) Token: 0x06001E80 RID: 7808 RVA: 0x000115AD File Offset: 0x0000F7AD
		public Material material
		{
			get
			{
				IntPtr intPtr = Projector.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				Projector.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400178C RID: 6028
		private static readonly Projector.get_nearClipPlaneDelegate get_nearClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.get_nearClipPlaneDelegate>("UnityEngine.Projector::get_nearClipPlane");

		// Token: 0x0400178D RID: 6029
		private static readonly Projector.set_nearClipPlaneDelegate set_nearClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.set_nearClipPlaneDelegate>("UnityEngine.Projector::set_nearClipPlane");

		// Token: 0x0400178E RID: 6030
		private static readonly Projector.get_farClipPlaneDelegate get_farClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.get_farClipPlaneDelegate>("UnityEngine.Projector::get_farClipPlane");

		// Token: 0x0400178F RID: 6031
		private static readonly Projector.set_farClipPlaneDelegate set_farClipPlaneDelegateField = IL2CPP.ResolveICall<Projector.set_farClipPlaneDelegate>("UnityEngine.Projector::set_farClipPlane");

		// Token: 0x04001790 RID: 6032
		private static readonly Projector.get_fieldOfViewDelegate get_fieldOfViewDelegateField = IL2CPP.ResolveICall<Projector.get_fieldOfViewDelegate>("UnityEngine.Projector::get_fieldOfView");

		// Token: 0x04001791 RID: 6033
		private static readonly Projector.set_fieldOfViewDelegate set_fieldOfViewDelegateField = IL2CPP.ResolveICall<Projector.set_fieldOfViewDelegate>("UnityEngine.Projector::set_fieldOfView");

		// Token: 0x04001792 RID: 6034
		private static readonly Projector.get_aspectRatioDelegate get_aspectRatioDelegateField = IL2CPP.ResolveICall<Projector.get_aspectRatioDelegate>("UnityEngine.Projector::get_aspectRatio");

		// Token: 0x04001793 RID: 6035
		private static readonly Projector.set_aspectRatioDelegate set_aspectRatioDelegateField = IL2CPP.ResolveICall<Projector.set_aspectRatioDelegate>("UnityEngine.Projector::set_aspectRatio");

		// Token: 0x04001794 RID: 6036
		private static readonly Projector.get_orthographicDelegate get_orthographicDelegateField = IL2CPP.ResolveICall<Projector.get_orthographicDelegate>("UnityEngine.Projector::get_orthographic");

		// Token: 0x04001795 RID: 6037
		private static readonly Projector.set_orthographicDelegate set_orthographicDelegateField = IL2CPP.ResolveICall<Projector.set_orthographicDelegate>("UnityEngine.Projector::set_orthographic");

		// Token: 0x04001796 RID: 6038
		private static readonly Projector.get_orthographicSizeDelegate get_orthographicSizeDelegateField = IL2CPP.ResolveICall<Projector.get_orthographicSizeDelegate>("UnityEngine.Projector::get_orthographicSize");

		// Token: 0x04001797 RID: 6039
		private static readonly Projector.set_orthographicSizeDelegate set_orthographicSizeDelegateField = IL2CPP.ResolveICall<Projector.set_orthographicSizeDelegate>("UnityEngine.Projector::set_orthographicSize");

		// Token: 0x04001798 RID: 6040
		private static readonly Projector.get_ignoreLayersDelegate get_ignoreLayersDelegateField = IL2CPP.ResolveICall<Projector.get_ignoreLayersDelegate>("UnityEngine.Projector::get_ignoreLayers");

		// Token: 0x04001799 RID: 6041
		private static readonly Projector.set_ignoreLayersDelegate set_ignoreLayersDelegateField = IL2CPP.ResolveICall<Projector.set_ignoreLayersDelegate>("UnityEngine.Projector::set_ignoreLayers");

		// Token: 0x0400179A RID: 6042
		private static readonly Projector.get_materialDelegate get_materialDelegateField = IL2CPP.ResolveICall<Projector.get_materialDelegate>("UnityEngine.Projector::get_material");

		// Token: 0x0400179B RID: 6043
		private static readonly Projector.set_materialDelegate set_materialDelegateField = IL2CPP.ResolveICall<Projector.set_materialDelegate>("UnityEngine.Projector::set_material");

		// Token: 0x02000BA7 RID: 2983
		// (Invoke) Token: 0x0600354C RID: 13644
		private delegate float get_nearClipPlaneDelegate(IntPtr @this);

		// Token: 0x02000BA8 RID: 2984
		// (Invoke) Token: 0x0600354E RID: 13646
		private delegate void set_nearClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000BA9 RID: 2985
		// (Invoke) Token: 0x06003550 RID: 13648
		private delegate float get_farClipPlaneDelegate(IntPtr @this);

		// Token: 0x02000BAA RID: 2986
		// (Invoke) Token: 0x06003552 RID: 13650
		private delegate void set_farClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000BAB RID: 2987
		// (Invoke) Token: 0x06003554 RID: 13652
		private delegate float get_fieldOfViewDelegate(IntPtr @this);

		// Token: 0x02000BAC RID: 2988
		// (Invoke) Token: 0x06003556 RID: 13654
		private delegate void set_fieldOfViewDelegate(IntPtr @this, float value);

		// Token: 0x02000BAD RID: 2989
		// (Invoke) Token: 0x06003558 RID: 13656
		private delegate float get_aspectRatioDelegate(IntPtr @this);

		// Token: 0x02000BAE RID: 2990
		// (Invoke) Token: 0x0600355A RID: 13658
		private delegate void set_aspectRatioDelegate(IntPtr @this, float value);

		// Token: 0x02000BAF RID: 2991
		// (Invoke) Token: 0x0600355C RID: 13660
		private delegate bool get_orthographicDelegate(IntPtr @this);

		// Token: 0x02000BB0 RID: 2992
		// (Invoke) Token: 0x0600355E RID: 13662
		private delegate void set_orthographicDelegate(IntPtr @this, bool value);

		// Token: 0x02000BB1 RID: 2993
		// (Invoke) Token: 0x06003560 RID: 13664
		private delegate float get_orthographicSizeDelegate(IntPtr @this);

		// Token: 0x02000BB2 RID: 2994
		// (Invoke) Token: 0x06003562 RID: 13666
		private delegate void set_orthographicSizeDelegate(IntPtr @this, float value);

		// Token: 0x02000BB3 RID: 2995
		// (Invoke) Token: 0x06003564 RID: 13668
		private delegate int get_ignoreLayersDelegate(IntPtr @this);

		// Token: 0x02000BB4 RID: 2996
		// (Invoke) Token: 0x06003566 RID: 13670
		private delegate void set_ignoreLayersDelegate(IntPtr @this, int value);

		// Token: 0x02000BB5 RID: 2997
		// (Invoke) Token: 0x06003568 RID: 13672
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000BB6 RID: 2998
		// (Invoke) Token: 0x0600356A RID: 13674
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);
	}
}
