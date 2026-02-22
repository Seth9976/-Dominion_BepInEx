using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000004 RID: 4
	public class MiniJson : Object
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002390 File Offset: 0x00000590
		// Note: this type is marked as 'beforefieldinit'.
		static MiniJson()
		{
			Il2CppClassPointerStore<MiniJson>.NativeClassPtr = IL2CPP.GetIl2CppClass("Purchasing.Common.dll", "UnityEngine.Purchasing", "MiniJson");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MiniJson>.NativeClassPtr);
			MiniJson.NativeMethodInfoPtr_JsonEncode_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJson>.NativeClassPtr, 100663302);
			MiniJson.NativeMethodInfoPtr_JsonDecode_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MiniJson>.NativeClassPtr, 100663303);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000023E8 File Offset: 0x000005E8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 89512, RefRangeEnd = 89525, XrefRangeStart = 89502, XrefRangeEnd = 89512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string JsonEncode(Object json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiniJson.NativeMethodInfoPtr_JsonEncode_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002424 File Offset: 0x00000624
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 89526, RefRangeEnd = 89537, XrefRangeStart = 89525, XrefRangeEnd = 89526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object JsonDecode(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MiniJson.NativeMethodInfoPtr_JsonDecode_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002089 File Offset: 0x00000289
		public MiniJson(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_JsonEncode_Public_Static_String_Object_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_JsonDecode_Public_Static_Object_String_0;
	}
}
