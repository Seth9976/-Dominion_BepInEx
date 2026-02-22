using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x020000B6 RID: 182
	public class IAsyncResult : Il2CppObjectBase
	{
		// Token: 0x06000CE1 RID: 3297 RVA: 0x0005C794 File Offset: 0x0005A994
		// Note: this type is marked as 'beforefieldinit'.
		static IAsyncResult()
		{
			Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "IAsyncResult");
			IAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665452);
			IAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Abstract_Virtual_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665453);
			IAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665454);
			IAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsyncResult>.NativeClassPtr, 100665455);
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0005C80C File Offset: 0x0005AA0C
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0005C854 File Offset: 0x0005AA54
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Abstract_Virtual_New_get_WaitHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0005C8A0 File Offset: 0x0005AAA0
		public unsafe virtual Object AsyncState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0005C8EC File Offset: 0x0005AAEC
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x00005663 File Offset: 0x00003863
		public IAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Abstract_Virtual_New_get_WaitHandle_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
