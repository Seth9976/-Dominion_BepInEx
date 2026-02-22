using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Resources
{
	// Token: 0x0200017D RID: 381
	public class IResourceReader : Il2CppObjectBase
	{
		// Token: 0x06001A63 RID: 6755 RVA: 0x00099DD8 File Offset: 0x00097FD8
		// Note: this type is marked as 'beforefieldinit'.
		static IResourceReader()
		{
			Il2CppClassPointerStore<IResourceReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "IResourceReader");
			IResourceReader.NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceReader>.NativeClassPtr, 100667757);
			IResourceReader.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResourceReader>.NativeClassPtr, 100667758);
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00099E28 File Offset: 0x00098028
		[CallerCount(0)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceReader.NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00099E64 File Offset: 0x00098064
		[CallerCount(0)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResourceReader.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00009004 File Offset: 0x00007204
		public IResourceReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IDictionaryEnumerator_0;
	}
}
