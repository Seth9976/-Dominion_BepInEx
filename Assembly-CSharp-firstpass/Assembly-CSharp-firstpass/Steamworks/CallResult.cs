using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002BB RID: 699
	public class CallResult : Object
	{
		// Token: 0x06002823 RID: 10275 RVA: 0x000AE3CC File Offset: 0x000AC5CC
		// Note: this type is marked as 'beforefieldinit'.
		static CallResult()
		{
			Il2CppClassPointerStore<CallResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "CallResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallResult>.NativeClassPtr);
			CallResult.NativeMethodInfoPtr_GetCallbackType_Internal_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult>.NativeClassPtr, 100668427);
			CallResult.NativeMethodInfoPtr_OnRunCallResult_Internal_Abstract_Virtual_New_Void_IntPtr_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult>.NativeClassPtr, 100668428);
			CallResult.NativeMethodInfoPtr_SetUnregistered_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult>.NativeClassPtr, 100668429);
			CallResult.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallResult>.NativeClassPtr, 100668430);
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x000AE44C File Offset: 0x000AC64C
		[CallerCount(0)]
		public unsafe virtual Type GetCallbackType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallResult.NativeMethodInfoPtr_GetCallbackType_Internal_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x000AE498 File Offset: 0x000AC698
		[CallerCount(0)]
		public unsafe virtual void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pvParam;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bFailed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamAPICall;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallResult.NativeMethodInfoPtr_OnRunCallResult_Internal_Abstract_Virtual_New_Void_IntPtr_Boolean_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000AE500 File Offset: 0x000AC700
		[CallerCount(0)]
		public unsafe virtual void SetUnregistered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallResult.NativeMethodInfoPtr_SetUnregistered_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000AE53C File Offset: 0x000AC73C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallResult>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallResult.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x000103F1 File Offset: 0x0000E5F1
		public CallResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002728 RID: 10024
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackType_Internal_Abstract_Virtual_New_Type_0;

		// Token: 0x04002729 RID: 10025
		private static readonly IntPtr NativeMethodInfoPtr_OnRunCallResult_Internal_Abstract_Virtual_New_Void_IntPtr_Boolean_UInt64_0;

		// Token: 0x0400272A RID: 10026
		private static readonly IntPtr NativeMethodInfoPtr_SetUnregistered_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x0400272B RID: 10027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
