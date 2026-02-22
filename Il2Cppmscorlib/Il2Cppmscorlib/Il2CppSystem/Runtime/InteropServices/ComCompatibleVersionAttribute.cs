using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044E RID: 1102
	public sealed class ComCompatibleVersionAttribute : Attribute
	{
		// Token: 0x060042E2 RID: 17122 RVA: 0x00132F18 File Offset: 0x00131118
		// Note: this type is marked as 'beforefieldinit'.
		static ComCompatibleVersionAttribute()
		{
			Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComCompatibleVersionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr);
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_major");
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_minor");
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_build");
			ComCompatibleVersionAttribute.NativeFieldInfoPtr__revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_revision");
			ComCompatibleVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, 100672980);
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x00132FAC File Offset: 0x001311AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 357440, XrefRangeEnd = 357441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref major;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minor;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref build;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref revision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComCompatibleVersionAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042E4 RID: 17124 RVA: 0x00019AEC File Offset: 0x00017CEC
		public ComCompatibleVersionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x060042E5 RID: 17125 RVA: 0x00133020 File Offset: 0x00131220
		// (set) Token: 0x060042E6 RID: 17126 RVA: 0x00019AF5 File Offset: 0x00017CF5
		public unsafe int _major
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__major);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__major)) = value;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x060042E7 RID: 17127 RVA: 0x00133048 File Offset: 0x00131248
		// (set) Token: 0x060042E8 RID: 17128 RVA: 0x00019B10 File Offset: 0x00017D10
		public unsafe int _minor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__minor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__minor)) = value;
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x060042E9 RID: 17129 RVA: 0x00133070 File Offset: 0x00131270
		// (set) Token: 0x060042EA RID: 17130 RVA: 0x00019B2B File Offset: 0x00017D2B
		public unsafe int _build
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__build);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__build)) = value;
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x060042EB RID: 17131 RVA: 0x00133098 File Offset: 0x00131298
		// (set) Token: 0x060042EC RID: 17132 RVA: 0x00019B46 File Offset: 0x00017D46
		public unsafe int _revision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__revision);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ComCompatibleVersionAttribute.NativeFieldInfoPtr__revision)) = value;
			}
		}

		// Token: 0x0400369C RID: 13980
		private static readonly IntPtr NativeFieldInfoPtr__major;

		// Token: 0x0400369D RID: 13981
		private static readonly IntPtr NativeFieldInfoPtr__minor;

		// Token: 0x0400369E RID: 13982
		private static readonly IntPtr NativeFieldInfoPtr__build;

		// Token: 0x0400369F RID: 13983
		private static readonly IntPtr NativeFieldInfoPtr__revision;

		// Token: 0x040036A0 RID: 13984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;
	}
}
