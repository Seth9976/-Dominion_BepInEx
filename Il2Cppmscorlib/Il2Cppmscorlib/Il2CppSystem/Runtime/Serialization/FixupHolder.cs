using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000335 RID: 821
	[Serializable]
	public class FixupHolder : Object
	{
		// Token: 0x06003520 RID: 13600 RVA: 0x001039F4 File Offset: 0x00101BF4
		// Note: this type is marked as 'beforefieldinit'.
		static FixupHolder()
		{
			Il2CppClassPointerStore<FixupHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FixupHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr);
			FixupHolder.NativeFieldInfoPtr_m_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_id");
			FixupHolder.NativeFieldInfoPtr_m_fixupInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_fixupInfo");
			FixupHolder.NativeFieldInfoPtr_m_fixupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_fixupType");
			FixupHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, 100671527);
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x00103A74 File Offset: 0x00101C74
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 22030, RefRangeEnd = 22036, XrefRangeStart = 22030, XrefRangeEnd = 22036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FixupHolder(long id, Object fixupInfo, int fixupType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fixupInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixupType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FixupHolder.NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x00012F8A File Offset: 0x0001118A
		public FixupHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06003523 RID: 13603 RVA: 0x00103ADC File Offset: 0x00101CDC
		// (set) Token: 0x06003524 RID: 13604 RVA: 0x00012F93 File Offset: 0x00011193
		public unsafe long m_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_id)) = value;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06003525 RID: 13605 RVA: 0x00103B04 File Offset: 0x00101D04
		// (set) Token: 0x06003526 RID: 13606 RVA: 0x00012FAE File Offset: 0x000111AE
		public unsafe Object m_fixupInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06003527 RID: 13607 RVA: 0x00103B34 File Offset: 0x00101D34
		// (set) Token: 0x06003528 RID: 13608 RVA: 0x00012FCD File Offset: 0x000111CD
		public unsafe int m_fixupType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FixupHolder.NativeFieldInfoPtr_m_fixupType)) = value;
			}
		}

		// Token: 0x04002CFC RID: 11516
		private static readonly IntPtr NativeFieldInfoPtr_m_id;

		// Token: 0x04002CFD RID: 11517
		private static readonly IntPtr NativeFieldInfoPtr_m_fixupInfo;

		// Token: 0x04002CFE RID: 11518
		private static readonly IntPtr NativeFieldInfoPtr_m_fixupType;

		// Token: 0x04002CFF RID: 11519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0;
	}
}
