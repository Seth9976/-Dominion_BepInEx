using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200027D RID: 637
	public class IThreadPoolWorkItem : Il2CppObjectBase
	{
		// Token: 0x06002BA8 RID: 11176 RVA: 0x000DFDD4 File Offset: 0x000DDFD4
		// Note: this type is marked as 'beforefieldinit'.
		static IThreadPoolWorkItem()
		{
			Il2CppClassPointerStore<IThreadPoolWorkItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "IThreadPoolWorkItem");
			IThreadPoolWorkItem.NativeMethodInfoPtr_ExecuteWorkItem_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IThreadPoolWorkItem>.NativeClassPtr, 100670243);
			IThreadPoolWorkItem.NativeMethodInfoPtr_MarkAborted_Public_Abstract_Virtual_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IThreadPoolWorkItem>.NativeClassPtr, 100670244);
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x000DFE24 File Offset: 0x000DE024
		[CallerCount(0)]
		public unsafe virtual void ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IThreadPoolWorkItem.NativeMethodInfoPtr_ExecuteWorkItem_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x000DFE60 File Offset: 0x000DE060
		[CallerCount(0)]
		public unsafe virtual void MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IThreadPoolWorkItem.NativeMethodInfoPtr_MarkAborted_Public_Abstract_Virtual_New_Void_ThreadAbortException_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x0000F2E5 File Offset: 0x0000D4E5
		public IThreadPoolWorkItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002613 RID: 9747
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteWorkItem_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002614 RID: 9748
		private static readonly IntPtr NativeMethodInfoPtr_MarkAborted_Public_Abstract_Virtual_New_Void_ThreadAbortException_0;
	}
}
