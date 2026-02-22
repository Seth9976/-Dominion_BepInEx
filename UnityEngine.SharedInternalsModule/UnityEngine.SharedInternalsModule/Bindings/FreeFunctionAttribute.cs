using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Bindings
{
	// Token: 0x02000015 RID: 21
	public class FreeFunctionAttribute : NativeMethodAttribute
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00003D9C File Offset: 0x00001F9C
		// Note: this type is marked as 'beforefieldinit'.
		static FreeFunctionAttribute()
		{
			Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "FreeFunctionAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr);
			FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr, 100663341);
			FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr, 100663342);
			FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr, 100663343);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003E08 File Offset: 0x00002008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58939, XrefRangeEnd = 58940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreeFunctionAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003E44 File Offset: 0x00002044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58940, XrefRangeEnd = 58941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreeFunctionAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003E90 File Offset: 0x00002090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58941, XrefRangeEnd = 58942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreeFunctionAttribute(string name, bool isThreadSafe)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeFunctionAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isThreadSafe;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeFunctionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002563 File Offset: 0x00000763
		public FreeFunctionAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;
	}
}
