using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x02000103 RID: 259
	public class ObjectSpin : MonoBehaviour
	{
		// Token: 0x06001ED0 RID: 7888 RVA: 0x0007836C File Offset: 0x0007656C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectSpin()
		{
			Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "ObjectSpin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr);
			ObjectSpin.NativeFieldInfoPtr_SpinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, "SpinSpeed");
			ObjectSpin.NativeFieldInfoPtr_RotationRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, "RotationRange");
			ObjectSpin.NativeFieldInfoPtr_m_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, "m_transform");
			ObjectSpin.NativeFieldInfoPtr_m_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, "m_time");
			ObjectSpin.NativeFieldInfoPtr_m_prevPOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, "m_prevPOS");
			ObjectSpin.NativeFieldInfoPtr_m_initial_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, "m_initial_Rotation");
			ObjectSpin.NativeFieldInfoPtr_m_initial_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, "m_initial_Position");
			ObjectSpin.NativeFieldInfoPtr_m_lightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, "m_lightColor");
			ObjectSpin.NativeFieldInfoPtr_frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, "frames");
			ObjectSpin.NativeFieldInfoPtr_Motion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, "Motion");
			ObjectSpin.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, 100665823);
			ObjectSpin.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, 100665824);
			ObjectSpin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr, 100665825);
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x000784A0 File Offset: 0x000766A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255952, XrefRangeEnd = 255967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSpin.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x000784D4 File Offset: 0x000766D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255967, XrefRangeEnd = 255971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSpin.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00078508 File Offset: 0x00076708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255971, XrefRangeEnd = 255972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSpin()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectSpin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectSpin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x000133C7 File Offset: 0x000115C7
		public ObjectSpin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x00078544 File Offset: 0x00076744
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x000133D0 File Offset: 0x000115D0
		public unsafe float SpinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_SpinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_SpinSpeed)) = value;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x0007856C File Offset: 0x0007676C
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x000133EB File Offset: 0x000115EB
		public unsafe int RotationRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_RotationRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_RotationRange)) = value;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x00078594 File Offset: 0x00076794
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x00013406 File Offset: 0x00011606
		public unsafe Transform m_transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x000785C4 File Offset: 0x000767C4
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x00013425 File Offset: 0x00011625
		public unsafe float m_time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_time)) = value;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x000785EC File Offset: 0x000767EC
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x00013440 File Offset: 0x00011640
		public unsafe Vector3 m_prevPOS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_prevPOS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_prevPOS)) = value;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00078614 File Offset: 0x00076814
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x0001345B File Offset: 0x0001165B
		public unsafe Vector3 m_initial_Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_initial_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_initial_Rotation)) = value;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x0007863C File Offset: 0x0007683C
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x00013476 File Offset: 0x00011676
		public unsafe Vector3 m_initial_Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_initial_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_initial_Position)) = value;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x00078664 File Offset: 0x00076864
		// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x00013491 File Offset: 0x00011691
		public unsafe Color32 m_lightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_lightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_m_lightColor)) = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x0007868C File Offset: 0x0007688C
		// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x000134AC File Offset: 0x000116AC
		public unsafe int frames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_frames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_frames)) = value;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x000786B4 File Offset: 0x000768B4
		// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x000134C7 File Offset: 0x000116C7
		public unsafe ObjectSpin.MotionType Motion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_Motion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectSpin.NativeFieldInfoPtr_Motion)) = value;
			}
		}

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeFieldInfoPtr_SpinSpeed;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeFieldInfoPtr_RotationRange;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeFieldInfoPtr_m_transform;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeFieldInfoPtr_m_time;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeFieldInfoPtr_m_prevPOS;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeFieldInfoPtr_m_initial_Rotation;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeFieldInfoPtr_m_initial_Position;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeFieldInfoPtr_m_lightColor;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeFieldInfoPtr_frames;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeFieldInfoPtr_Motion;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000225 RID: 549
		public enum MotionType
		{
			// Token: 0x04001D0E RID: 7438
			Rotation,
			// Token: 0x04001D0F RID: 7439
			BackAndForth,
			// Token: 0x04001D10 RID: 7440
			Translation
		}
	}
}
