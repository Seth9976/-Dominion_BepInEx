using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A3 RID: 931
	[Serializable]
	public class TypeInfo : Object
	{
		// Token: 0x06003CAE RID: 15534 RVA: 0x0011D78C File Offset: 0x0011B98C
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInfo()
		{
			Il2CppClassPointerStore<TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "TypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr);
			TypeInfo.NativeFieldInfoPtr_serverType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, "serverType");
			TypeInfo.NativeFieldInfoPtr_serverHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, "serverHierarchy");
			TypeInfo.NativeFieldInfoPtr_interfacesImplemented = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, "interfacesImplemented");
			TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100672247);
			TypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100672248);
			TypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100672249);
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x0011D834 File Offset: 0x0011BA34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 351375, RefRangeEnd = 351377, XrefRangeStart = 351341, XrefRangeEnd = 351375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInfo(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06003CB0 RID: 15536 RVA: 0x0011D880 File Offset: 0x0011BA80
		public unsafe virtual string TypeName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x0011D8B8 File Offset: 0x0011BAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351377, XrefRangeEnd = 351407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanCastTo(Type fromType, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003CB2 RID: 15538 RVA: 0x00016D29 File Offset: 0x00014F29
		public TypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x0011D918 File Offset: 0x0011BB18
		// (set) Token: 0x06003CB4 RID: 15540 RVA: 0x00016D32 File Offset: 0x00014F32
		public unsafe string serverType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06003CB5 RID: 15541 RVA: 0x0011D940 File Offset: 0x0011BB40
		// (set) Token: 0x06003CB6 RID: 15542 RVA: 0x00016D51 File Offset: 0x00014F51
		public unsafe Il2CppStringArray serverHierarchy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverHierarchy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverHierarchy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x0011D970 File Offset: 0x0011BB70
		// (set) Token: 0x06003CB8 RID: 15544 RVA: 0x00016D70 File Offset: 0x00014F70
		public unsafe Il2CppStringArray interfacesImplemented
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_interfacesImplemented);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_interfacesImplemented), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003253 RID: 12883
		private static readonly IntPtr NativeFieldInfoPtr_serverType;

		// Token: 0x04003254 RID: 12884
		private static readonly IntPtr NativeFieldInfoPtr_serverHierarchy;

		// Token: 0x04003255 RID: 12885
		private static readonly IntPtr NativeFieldInfoPtr_interfacesImplemented;

		// Token: 0x04003256 RID: 12886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x04003257 RID: 12887
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003258 RID: 12888
		private static readonly IntPtr NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0;
	}
}
