using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F9 RID: 249
	public class AutoWebProxyScriptEngine : Object
	{
		// Token: 0x06000ED2 RID: 3794 RVA: 0x000481C4 File Offset: 0x000463C4
		// Note: this type is marked as 'beforefieldinit'.
		static AutoWebProxyScriptEngine()
		{
			Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "AutoWebProxyScriptEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr);
			AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr, 100665365);
			AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoWebProxyScriptEngine>.NativeClassPtr, 100665366);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0004821C File Offset: 0x0004641C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 49498, RefRangeEnd = 49501, XrefRangeStart = 49498, XrefRangeEnd = 49498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetProxies(Uri destination, out IList<string> proxyList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			proxyList = ((intPtr4 == 0) ? null : new IList<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0004828C File Offset: 0x0004648C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 49498, RefRangeEnd = 49501, XrefRangeStart = 49498, XrefRangeEnd = 49501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetProxies(Uri destination, out IList<string> proxyList, ref int syncStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &syncStatus;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AutoWebProxyScriptEngine.NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			proxyList = ((intPtr4 == 0) ? null : new IList<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00007D75 File Offset: 0x00005F75
		public AutoWebProxyScriptEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_GetProxies_Public_Boolean_Uri_byref_IList_1_String_byref_Int32_0;
	}
}
