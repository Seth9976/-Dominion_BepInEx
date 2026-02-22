using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	public sealed class HumanBone : ValueType
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00008FBC File Offset: 0x000071BC
		// Note: this type is marked as 'beforefieldinit'.
		static HumanBone()
		{
			Il2CppClassPointerStore<HumanBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanBone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanBone>.NativeClassPtr);
			HumanBone.NativeFieldInfoPtr_m_BoneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "m_BoneName");
			HumanBone.NativeFieldInfoPtr_m_HumanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "m_HumanName");
			HumanBone.NativeFieldInfoPtr_limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "limit");
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000033E7 File Offset: 0x000015E7
		public HumanBone(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000033F0 File Offset: 0x000015F0
		public HumanBone()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HumanBone>.NativeClassPtr))
		{
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00009028 File Offset: 0x00007228
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x00003402 File Offset: 0x00001602
		public unsafe string m_BoneName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_BoneName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_BoneName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00009050 File Offset: 0x00007250
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x00003421 File Offset: 0x00001621
		public unsafe string m_HumanName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_HumanName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_m_HumanName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00009078 File Offset: 0x00007278
		// (set) Token: 0x060001EA RID: 490 RVA: 0x00003440 File Offset: 0x00001640
		public unsafe HumanLimit limit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_limit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanBone.NativeFieldInfoPtr_limit)) = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000090A0 File Offset: 0x000072A0
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0000345B File Offset: 0x0000165B
		public string boneName
		{
			get
			{
				return this.m_BoneName;
			}
			set
			{
				this.m_BoneName = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000090B8 File Offset: 0x000072B8
		// (set) Token: 0x060001EE RID: 494 RVA: 0x00003465 File Offset: 0x00001665
		public string humanName
		{
			get
			{
				return this.m_HumanName;
			}
			set
			{
				this.m_HumanName = value;
			}
		}

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeFieldInfoPtr_m_BoneName;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeFieldInfoPtr_m_HumanName;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeFieldInfoPtr_limit;
	}
}
