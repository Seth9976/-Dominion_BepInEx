using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033E RID: 830
	public sealed class OptionalFieldAttribute : Attribute
	{
		// Token: 0x06003585 RID: 13701 RVA: 0x00104E28 File Offset: 0x00103028
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalFieldAttribute()
		{
			Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OptionalFieldAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr);
			OptionalFieldAttribute.NativeFieldInfoPtr_versionAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, "versionAdded");
			OptionalFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, 100671564);
			OptionalFieldAttribute.NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, 100671565);
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x00104E94 File Offset: 0x00103094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343516, XrefRangeEnd = 343517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionalFieldAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CE9 RID: 3305
		// (set) Token: 0x06003587 RID: 13703 RVA: 0x00104ED0 File Offset: 0x001030D0
		public unsafe int VersionAdded
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFieldAttribute.NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x000132BA File Offset: 0x000114BA
		public OptionalFieldAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x00104F10 File Offset: 0x00103110
		// (set) Token: 0x0600358A RID: 13706 RVA: 0x000132C3 File Offset: 0x000114C3
		public unsafe int versionAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionalFieldAttribute.NativeFieldInfoPtr_versionAdded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionalFieldAttribute.NativeFieldInfoPtr_versionAdded)) = value;
			}
		}

		// Token: 0x04002D38 RID: 11576
		private static readonly IntPtr NativeFieldInfoPtr_versionAdded;

		// Token: 0x04002D39 RID: 11577
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D3A RID: 11578
		private static readonly IntPtr NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0;
	}
}
