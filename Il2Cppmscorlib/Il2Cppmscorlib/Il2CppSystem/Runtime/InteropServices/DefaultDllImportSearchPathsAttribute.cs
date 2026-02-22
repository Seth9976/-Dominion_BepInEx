using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200044B RID: 1099
	public sealed class DefaultDllImportSearchPathsAttribute : Attribute
	{
		// Token: 0x060042BF RID: 17087 RVA: 0x0013290C File Offset: 0x00130B0C
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultDllImportSearchPathsAttribute()
		{
			Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "DefaultDllImportSearchPathsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr);
			DefaultDllImportSearchPathsAttribute.NativeFieldInfoPtr__paths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr, "_paths");
			DefaultDllImportSearchPathsAttribute.NativeMethodInfoPtr__ctor_Public_Void_DllImportSearchPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr, 100672973);
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x00132964 File Offset: 0x00130B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultDllImportSearchPathsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref paths;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultDllImportSearchPathsAttribute.NativeMethodInfoPtr__ctor_Public_Void_DllImportSearchPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x000199A0 File Offset: 0x00017BA0
		public DefaultDllImportSearchPathsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x060042C2 RID: 17090 RVA: 0x001329AC File Offset: 0x00130BAC
		// (set) Token: 0x060042C3 RID: 17091 RVA: 0x000199A9 File Offset: 0x00017BA9
		public unsafe DllImportSearchPath _paths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDllImportSearchPathsAttribute.NativeFieldInfoPtr__paths);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultDllImportSearchPathsAttribute.NativeFieldInfoPtr__paths)) = value;
			}
		}

		// Token: 0x0400368A RID: 13962
		private static readonly IntPtr NativeFieldInfoPtr__paths;

		// Token: 0x0400368B RID: 13963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DllImportSearchPath_0;
	}
}
