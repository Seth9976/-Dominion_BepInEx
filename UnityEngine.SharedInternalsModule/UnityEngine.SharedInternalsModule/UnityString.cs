using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public sealed class UnityString : Object
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000021D3 File Offset: 0x000003D3
		// Note: this type is marked as 'beforefieldinit'.
		static UnityString()
		{
			Il2CppClassPointerStore<UnityString>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine", "UnityString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityString>.NativeClassPtr);
			UnityString.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityString>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002BBC File Offset: 0x00000DBC
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 58882, RefRangeEnd = 58908, XrefRangeStart = 58876, XrefRangeEnd = 58882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string fmt, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fmt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityString.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000220C File Offset: 0x0000040C
		public static string Format(string fmt, params Object[] args)
		{
			return UnityString.Format(fmt, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000221A File Offset: 0x0000041A
		public UnityString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;
	}
}
