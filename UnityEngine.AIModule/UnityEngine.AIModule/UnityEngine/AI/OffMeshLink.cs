using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.AI
{
	// Token: 0x0200000D RID: 13
	public sealed class OffMeshLink : Behaviour
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000029A5 File Offset: 0x00000BA5
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000029B7 File Offset: 0x00000BB7
		public bool activated
		{
			get
			{
				return OffMeshLink.get_activatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OffMeshLink.set_activatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000029CA File Offset: 0x00000BCA
		public bool occupied
		{
			get
			{
				return OffMeshLink.get_occupiedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000029DC File Offset: 0x00000BDC
		// (set) Token: 0x060000AE RID: 174 RVA: 0x000029EE File Offset: 0x00000BEE
		public float costOverride
		{
			get
			{
				return OffMeshLink.get_costOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OffMeshLink.set_costOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002A01 File Offset: 0x00000C01
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002A13 File Offset: 0x00000C13
		public bool biDirectional
		{
			get
			{
				return OffMeshLink.get_biDirectionalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OffMeshLink.set_biDirectionalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002A26 File Offset: 0x00000C26
		public void UpdatePositions()
		{
			OffMeshLink.UpdatePositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000036F0 File Offset: 0x000018F0
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002A38 File Offset: 0x00000C38
		public int navMeshLayer
		{
			get
			{
				return this.area;
			}
			set
			{
				this.area = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002A43 File Offset: 0x00000C43
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002A55 File Offset: 0x00000C55
		public int area
		{
			get
			{
				return OffMeshLink.get_areaDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OffMeshLink.set_areaDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002A68 File Offset: 0x00000C68
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002A7A File Offset: 0x00000C7A
		public bool autoUpdatePositions
		{
			get
			{
				return OffMeshLink.get_autoUpdatePositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				OffMeshLink.set_autoUpdatePositionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00003708 File Offset: 0x00001908
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002A8D File Offset: 0x00000C8D
		public Transform startTransform
		{
			get
			{
				IntPtr intPtr = OffMeshLink.get_startTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				OffMeshLink.set_startTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00003734 File Offset: 0x00001934
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002AA5 File Offset: 0x00000CA5
		public Transform endTransform
		{
			get
			{
				IntPtr intPtr = OffMeshLink.get_endTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				OffMeshLink.set_endTransformDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400008F RID: 143
		private static readonly OffMeshLink.get_activatedDelegate get_activatedDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_activatedDelegate>("UnityEngine.AI.OffMeshLink::get_activated");

		// Token: 0x04000090 RID: 144
		private static readonly OffMeshLink.set_activatedDelegate set_activatedDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_activatedDelegate>("UnityEngine.AI.OffMeshLink::set_activated");

		// Token: 0x04000091 RID: 145
		private static readonly OffMeshLink.get_occupiedDelegate get_occupiedDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_occupiedDelegate>("UnityEngine.AI.OffMeshLink::get_occupied");

		// Token: 0x04000092 RID: 146
		private static readonly OffMeshLink.get_costOverrideDelegate get_costOverrideDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_costOverrideDelegate>("UnityEngine.AI.OffMeshLink::get_costOverride");

		// Token: 0x04000093 RID: 147
		private static readonly OffMeshLink.set_costOverrideDelegate set_costOverrideDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_costOverrideDelegate>("UnityEngine.AI.OffMeshLink::set_costOverride");

		// Token: 0x04000094 RID: 148
		private static readonly OffMeshLink.get_biDirectionalDelegate get_biDirectionalDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_biDirectionalDelegate>("UnityEngine.AI.OffMeshLink::get_biDirectional");

		// Token: 0x04000095 RID: 149
		private static readonly OffMeshLink.set_biDirectionalDelegate set_biDirectionalDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_biDirectionalDelegate>("UnityEngine.AI.OffMeshLink::set_biDirectional");

		// Token: 0x04000096 RID: 150
		private static readonly OffMeshLink.UpdatePositionsDelegate UpdatePositionsDelegateField = IL2CPP.ResolveICall<OffMeshLink.UpdatePositionsDelegate>("UnityEngine.AI.OffMeshLink::UpdatePositions");

		// Token: 0x04000097 RID: 151
		private static readonly OffMeshLink.get_areaDelegate get_areaDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_areaDelegate>("UnityEngine.AI.OffMeshLink::get_area");

		// Token: 0x04000098 RID: 152
		private static readonly OffMeshLink.set_areaDelegate set_areaDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_areaDelegate>("UnityEngine.AI.OffMeshLink::set_area");

		// Token: 0x04000099 RID: 153
		private static readonly OffMeshLink.get_autoUpdatePositionsDelegate get_autoUpdatePositionsDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_autoUpdatePositionsDelegate>("UnityEngine.AI.OffMeshLink::get_autoUpdatePositions");

		// Token: 0x0400009A RID: 154
		private static readonly OffMeshLink.set_autoUpdatePositionsDelegate set_autoUpdatePositionsDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_autoUpdatePositionsDelegate>("UnityEngine.AI.OffMeshLink::set_autoUpdatePositions");

		// Token: 0x0400009B RID: 155
		private static readonly OffMeshLink.get_startTransformDelegate get_startTransformDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_startTransformDelegate>("UnityEngine.AI.OffMeshLink::get_startTransform");

		// Token: 0x0400009C RID: 156
		private static readonly OffMeshLink.set_startTransformDelegate set_startTransformDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_startTransformDelegate>("UnityEngine.AI.OffMeshLink::set_startTransform");

		// Token: 0x0400009D RID: 157
		private static readonly OffMeshLink.get_endTransformDelegate get_endTransformDelegateField = IL2CPP.ResolveICall<OffMeshLink.get_endTransformDelegate>("UnityEngine.AI.OffMeshLink::get_endTransform");

		// Token: 0x0400009E RID: 158
		private static readonly OffMeshLink.set_endTransformDelegate set_endTransformDelegateField = IL2CPP.ResolveICall<OffMeshLink.set_endTransformDelegate>("UnityEngine.AI.OffMeshLink::set_endTransform");

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060001C5 RID: 453
		private delegate bool get_activatedDelegate(IntPtr @this);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x060001C7 RID: 455
		private delegate void set_activatedDelegate(IntPtr @this, bool value);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x060001C9 RID: 457
		private delegate bool get_occupiedDelegate(IntPtr @this);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x060001CB RID: 459
		private delegate float get_costOverrideDelegate(IntPtr @this);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x060001CD RID: 461
		private delegate void set_costOverrideDelegate(IntPtr @this, float value);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x060001CF RID: 463
		private delegate bool get_biDirectionalDelegate(IntPtr @this);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x060001D1 RID: 465
		private delegate void set_biDirectionalDelegate(IntPtr @this, bool value);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x060001D3 RID: 467
		private delegate void UpdatePositionsDelegate(IntPtr @this);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x060001D5 RID: 469
		private delegate int get_areaDelegate(IntPtr @this);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x060001D7 RID: 471
		private delegate void set_areaDelegate(IntPtr @this, int value);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x060001D9 RID: 473
		private delegate bool get_autoUpdatePositionsDelegate(IntPtr @this);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x060001DB RID: 475
		private delegate void set_autoUpdatePositionsDelegate(IntPtr @this, bool value);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x060001DD RID: 477
		private delegate IntPtr get_startTransformDelegate(IntPtr @this);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x060001DF RID: 479
		private delegate void set_startTransformDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x060001E1 RID: 481
		private delegate IntPtr get_endTransformDelegate(IntPtr @this);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x060001E3 RID: 483
		private delegate void set_endTransformDelegate(IntPtr @this, IntPtr value);
	}
}
