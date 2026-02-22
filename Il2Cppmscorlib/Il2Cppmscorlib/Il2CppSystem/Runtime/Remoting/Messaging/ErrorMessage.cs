using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003F2 RID: 1010
	[Serializable]
	public class ErrorMessage : Object
	{
		// Token: 0x06003FEF RID: 16367 RVA: 0x00128E40 File Offset: 0x00127040
		// Note: this type is marked as 'beforefieldinit'.
		static ErrorMessage()
		{
			Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ErrorMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr);
			ErrorMessage.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, "_uri");
			ErrorMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, 100672632);
			ErrorMessage.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, 100672633);
			ErrorMessage.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, 100672634);
			ErrorMessage.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, 100672635);
			ErrorMessage.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, 100672636);
			ErrorMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, 100672637);
			ErrorMessage.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, 100672638);
			ErrorMessage.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, 100672639);
			ErrorMessage.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, 100672640);
			ErrorMessage.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, 100672641);
			ErrorMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr, 100672642);
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x00128F60 File Offset: 0x00127160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355020, RefRangeEnd = 355021, XrefRangeStart = 355017, XrefRangeEnd = 355020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06003FF1 RID: 16369 RVA: 0x00128F9C File Offset: 0x0012719C
		public unsafe virtual int ArgCount
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorMessage.NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06003FF2 RID: 16370 RVA: 0x00128FD8 File Offset: 0x001271D8
		public unsafe virtual Il2CppReferenceArray<Object> Args
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorMessage.NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06003FF3 RID: 16371 RVA: 0x00129018 File Offset: 0x00127218
		public unsafe virtual MethodBase MethodBase
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorMessage.NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06003FF4 RID: 16372 RVA: 0x00129058 File Offset: 0x00127258
		public unsafe virtual string MethodName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355021, XrefRangeEnd = 355023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorMessage.NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06003FF5 RID: 16373 RVA: 0x00129090 File Offset: 0x00127290
		public unsafe virtual Object MethodSignature
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorMessage.NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x06003FF6 RID: 16374 RVA: 0x001290D0 File Offset: 0x001272D0
		public unsafe virtual IDictionary Properties
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ErrorMessage.NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x06003FF7 RID: 16375 RVA: 0x0012911C File Offset: 0x0012731C
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355023, XrefRangeEnd = 355025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorMessage.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x06003FF8 RID: 16376 RVA: 0x00129154 File Offset: 0x00127354
		public unsafe virtual string Uri
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorMessage.NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x0012918C File Offset: 0x0012738C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetArg(int arg_num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arg_num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorMessage.NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x06003FFA RID: 16378 RVA: 0x001291D8 File Offset: 0x001273D8
		public unsafe virtual LogicalCallContext LogicalCallContext
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ErrorMessage.NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x000183A4 File Offset: 0x000165A4
		public ErrorMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06003FFC RID: 16380 RVA: 0x00129218 File Offset: 0x00127418
		// (set) Token: 0x06003FFD RID: 16381 RVA: 0x000183AD File Offset: 0x000165AD
		public unsafe string _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorMessage.NativeFieldInfoPtr__uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ErrorMessage.NativeFieldInfoPtr__uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003467 RID: 13415
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x04003468 RID: 13416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003469 RID: 13417
		private static readonly IntPtr NativeMethodInfoPtr_get_ArgCount_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400346A RID: 13418
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400346B RID: 13419
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodBase_Public_Virtual_Final_New_get_MethodBase_0;

		// Token: 0x0400346C RID: 13420
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400346D RID: 13421
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodSignature_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400346E RID: 13422
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_New_get_IDictionary_0;

		// Token: 0x0400346F RID: 13423
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003470 RID: 13424
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003471 RID: 13425
		private static readonly IntPtr NativeMethodInfoPtr_GetArg_Public_Virtual_Final_New_Object_Int32_0;

		// Token: 0x04003472 RID: 13426
		private static readonly IntPtr NativeMethodInfoPtr_get_LogicalCallContext_Public_Virtual_Final_New_get_LogicalCallContext_0;
	}
}
