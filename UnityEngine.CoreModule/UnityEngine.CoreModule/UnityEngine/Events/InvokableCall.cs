using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020000FC RID: 252
	public class InvokableCall : BaseInvokableCall
	{
		// Token: 0x06001560 RID: 5472 RVA: 0x000511EC File Offset: 0x0004F3EC
		// Note: this type is marked as 'beforefieldinit'.
		static InvokableCall()
		{
			Il2CppClassPointerStore<InvokableCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "InvokableCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr);
			InvokableCall.NativeFieldInfoPtr_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, "Delegate");
			InvokableCall.NativeMethodInfoPtr_add_Delegate_Private_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100664863);
			InvokableCall.NativeMethodInfoPtr_remove_Delegate_Private_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100664864);
			InvokableCall.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100664865);
			InvokableCall.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100664866);
			InvokableCall.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100664867);
			InvokableCall.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100664868);
			InvokableCall.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr, 100664869);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x000512BC File Offset: 0x0004F4BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80004, RefRangeEnd = 80006, XrefRangeStart = 80000, XrefRangeEnd = 80004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Delegate(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall.NativeMethodInfoPtr_add_Delegate_Private_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00051300 File Offset: 0x0004F500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80006, XrefRangeEnd = 80010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Delegate(UnityAction value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall.NativeMethodInfoPtr_remove_Delegate_Private_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00051344 File Offset: 0x0004F544
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80042, RefRangeEnd = 80044, XrefRangeStart = 80010, XrefRangeEnd = 80042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(Object target, MethodInfo theFunction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000513A4 File Offset: 0x0004F5A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80046, RefRangeEnd = 80048, XrefRangeStart = 80044, XrefRangeEnd = 80046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(UnityAction action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x000513F0 File Offset: 0x0004F5F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 80050, RefRangeEnd = 80055, XrefRangeStart = 80048, XrefRangeEnd = 80050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Invoke(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00051440 File Offset: 0x0004F640
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 80050, RefRangeEnd = 80055, XrefRangeStart = 80050, XrefRangeEnd = 80055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00051474 File Offset: 0x0004F674
		[CallerCount(0)]
		public unsafe override bool Find(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0000C42D File Offset: 0x0000A62D
		public InvokableCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x000514E0 File Offset: 0x0004F6E0
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x0000C436 File Offset: 0x0000A636
		public unsafe UnityAction Delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall.NativeFieldInfoPtr_Delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall.NativeFieldInfoPtr_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeFieldInfoPtr_Delegate;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeMethodInfoPtr_add_Delegate_Private_add_Void_UnityAction_0;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_remove_Delegate_Private_rem_Void_UnityAction_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityAction_0;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0;
	}
}
