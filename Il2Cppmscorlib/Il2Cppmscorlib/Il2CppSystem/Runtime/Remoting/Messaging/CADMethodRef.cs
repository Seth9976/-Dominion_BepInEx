using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E8 RID: 1000
	[Serializable]
	public class CADMethodRef : Object
	{
		// Token: 0x06003F6A RID: 16234 RVA: 0x00126DE4 File Offset: 0x00124FE4
		// Note: this type is marked as 'beforefieldinit'.
		static CADMethodRef()
		{
			Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMethodRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr);
			CADMethodRef.NativeFieldInfoPtr_ctor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "ctor");
			CADMethodRef.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "typeName");
			CADMethodRef.NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "methodName");
			CADMethodRef.NativeFieldInfoPtr_param_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "param_names");
			CADMethodRef.NativeFieldInfoPtr_generic_arg_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, "generic_arg_names");
			CADMethodRef.NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100672569);
			CADMethodRef.NativeMethodInfoPtr_Resolve_Public_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100672570);
			CADMethodRef.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr, 100672571);
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x00126EB4 File Offset: 0x001250B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 354328, RefRangeEnd = 354331, XrefRangeStart = 354315, XrefRangeEnd = 354328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Type> GetTypes(Il2CppStringArray typeArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodRef.NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
			}
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x00126F04 File Offset: 0x00125104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354357, RefRangeEnd = 354359, XrefRangeStart = 354331, XrefRangeEnd = 354357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodBase Resolve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodRef.NativeMethodInfoPtr_Resolve_Public_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x00126F44 File Offset: 0x00125144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354374, RefRangeEnd = 354375, XrefRangeStart = 354359, XrefRangeEnd = 354374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMethodRef(IMethodMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMethodRef>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodRef.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x0001804A File Offset: 0x0001624A
		public CADMethodRef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06003F6F RID: 16239 RVA: 0x00126F90 File Offset: 0x00125190
		// (set) Token: 0x06003F70 RID: 16240 RVA: 0x00018053 File Offset: 0x00016253
		public unsafe bool ctor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_ctor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_ctor)) = value;
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06003F71 RID: 16241 RVA: 0x00126FB8 File Offset: 0x001251B8
		// (set) Token: 0x06003F72 RID: 16242 RVA: 0x0001806E File Offset: 0x0001626E
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06003F73 RID: 16243 RVA: 0x00126FE0 File Offset: 0x001251E0
		// (set) Token: 0x06003F74 RID: 16244 RVA: 0x0001808D File Offset: 0x0001628D
		public unsafe string methodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_methodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06003F75 RID: 16245 RVA: 0x00127008 File Offset: 0x00125208
		// (set) Token: 0x06003F76 RID: 16246 RVA: 0x000180AC File Offset: 0x000162AC
		public unsafe Il2CppStringArray param_names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_param_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_param_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06003F77 RID: 16247 RVA: 0x00127038 File Offset: 0x00125238
		// (set) Token: 0x06003F78 RID: 16248 RVA: 0x000180CB File Offset: 0x000162CB
		public unsafe Il2CppStringArray generic_arg_names
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_generic_arg_names);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodRef.NativeFieldInfoPtr_generic_arg_names), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003410 RID: 13328
		private static readonly IntPtr NativeFieldInfoPtr_ctor;

		// Token: 0x04003411 RID: 13329
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04003412 RID: 13330
		private static readonly IntPtr NativeFieldInfoPtr_methodName;

		// Token: 0x04003413 RID: 13331
		private static readonly IntPtr NativeFieldInfoPtr_param_names;

		// Token: 0x04003414 RID: 13332
		private static readonly IntPtr NativeFieldInfoPtr_generic_arg_names;

		// Token: 0x04003415 RID: 13333
		private static readonly IntPtr NativeMethodInfoPtr_GetTypes_Private_Il2CppReferenceArray_1_Type_Il2CppStringArray_0;

		// Token: 0x04003416 RID: 13334
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_MethodBase_0;

		// Token: 0x04003417 RID: 13335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;
	}
}
