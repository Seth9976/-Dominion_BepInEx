using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002B9 RID: 697
	public class Callback : Object
	{
		// Token: 0x06002805 RID: 10245 RVA: 0x000ADC3C File Offset: 0x000ABE3C
		// Note: this type is marked as 'beforefieldinit'.
		static Callback()
		{
			Il2CppClassPointerStore<Callback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "Callback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Callback>.NativeClassPtr);
			Callback.NativeMethodInfoPtr_get_IsGameServer_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback>.NativeClassPtr, 100668409);
			Callback.NativeMethodInfoPtr_GetCallbackType_Internal_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback>.NativeClassPtr, 100668410);
			Callback.NativeMethodInfoPtr_OnRunCallback_Internal_Abstract_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback>.NativeClassPtr, 100668411);
			Callback.NativeMethodInfoPtr_SetUnregistered_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback>.NativeClassPtr, 100668412);
			Callback.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Callback>.NativeClassPtr, 100668413);
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x000ADCD0 File Offset: 0x000ABED0
		public unsafe virtual bool IsGameServer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Callback.NativeMethodInfoPtr_get_IsGameServer_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000ADD18 File Offset: 0x000ABF18
		[CallerCount(0)]
		public unsafe virtual Type GetCallbackType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Callback.NativeMethodInfoPtr_GetCallbackType_Internal_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000ADD64 File Offset: 0x000ABF64
		[CallerCount(0)]
		public unsafe virtual void OnRunCallback(IntPtr pvParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pvParam;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Callback.NativeMethodInfoPtr_OnRunCallback_Internal_Abstract_Virtual_New_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000ADDB0 File Offset: 0x000ABFB0
		[CallerCount(0)]
		public unsafe virtual void SetUnregistered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Callback.NativeMethodInfoPtr_SetUnregistered_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000ADDEC File Offset: 0x000ABFEC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Callback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Callback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Callback.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x0001036F File Offset: 0x0000E56F
		public Callback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002712 RID: 10002
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGameServer_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002713 RID: 10003
		private static readonly IntPtr NativeMethodInfoPtr_GetCallbackType_Internal_Abstract_Virtual_New_Type_0;

		// Token: 0x04002714 RID: 10004
		private static readonly IntPtr NativeMethodInfoPtr_OnRunCallback_Internal_Abstract_Virtual_New_Void_IntPtr_0;

		// Token: 0x04002715 RID: 10005
		private static readonly IntPtr NativeMethodInfoPtr_SetUnregistered_Internal_Abstract_Virtual_New_Void_0;

		// Token: 0x04002716 RID: 10006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
