using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200038B RID: 907
	public class ActivatedClientTypeEntry : TypeEntry
	{
		// Token: 0x06003B20 RID: 15136 RVA: 0x00117844 File Offset: 0x00115A44
		// Note: this type is marked as 'beforefieldinit'.
		static ActivatedClientTypeEntry()
		{
			Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ActivatedClientTypeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr);
			ActivatedClientTypeEntry.NativeFieldInfoPtr_applicationUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, "applicationUrl");
			ActivatedClientTypeEntry.NativeFieldInfoPtr_obj_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, "obj_type");
			ActivatedClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100672045);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100672046);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ContextAttributes_Public_get_Il2CppReferenceArray_1_IContextAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100672047);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100672048);
			ActivatedClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr, 100672049);
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x00117900 File Offset: 0x00115B00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 348754, RefRangeEnd = 348756, XrefRangeStart = 348748, XrefRangeEnd = 348754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivatedClientTypeEntry(string typeName, string assemblyName, string appUrl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivatedClientTypeEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(appUrl);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06003B22 RID: 15138 RVA: 0x00117970 File Offset: 0x00115B70
		public unsafe string ApplicationUrl
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06003B23 RID: 15139 RVA: 0x001179A8 File Offset: 0x00115BA8
		public unsafe Il2CppReferenceArray<IContextAttribute> ContextAttributes
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ContextAttributes_Public_get_Il2CppReferenceArray_1_IContextAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IContextAttribute>>(intPtr3) : null;
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x001179E8 File Offset: 0x00115BE8
		public unsafe Type ObjectType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivatedClientTypeEntry.NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003B25 RID: 15141 RVA: 0x00117A28 File Offset: 0x00115C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348756, XrefRangeEnd = 348757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActivatedClientTypeEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x000163F1 File Offset: 0x000145F1
		public ActivatedClientTypeEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06003B27 RID: 15143 RVA: 0x00117A6C File Offset: 0x00115C6C
		// (set) Token: 0x06003B28 RID: 15144 RVA: 0x000163FA File Offset: 0x000145FA
		public unsafe string applicationUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_applicationUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_applicationUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06003B29 RID: 15145 RVA: 0x00117A94 File Offset: 0x00115C94
		// (set) Token: 0x06003B2A RID: 15146 RVA: 0x00016419 File Offset: 0x00014619
		public unsafe Type obj_type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_obj_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActivatedClientTypeEntry.NativeFieldInfoPtr_obj_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003143 RID: 12611
		private static readonly IntPtr NativeFieldInfoPtr_applicationUrl;

		// Token: 0x04003144 RID: 12612
		private static readonly IntPtr NativeFieldInfoPtr_obj_type;

		// Token: 0x04003145 RID: 12613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;

		// Token: 0x04003146 RID: 12614
		private static readonly IntPtr NativeMethodInfoPtr_get_ApplicationUrl_Public_get_String_0;

		// Token: 0x04003147 RID: 12615
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextAttributes_Public_get_Il2CppReferenceArray_1_IContextAttribute_0;

		// Token: 0x04003148 RID: 12616
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectType_Public_get_Type_0;

		// Token: 0x04003149 RID: 12617
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
