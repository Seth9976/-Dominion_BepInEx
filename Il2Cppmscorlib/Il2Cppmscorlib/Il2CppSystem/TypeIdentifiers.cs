using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000140 RID: 320
	public class TypeIdentifiers : Object
	{
		// Token: 0x060016A9 RID: 5801 RVA: 0x00007FD9 File Offset: 0x000061D9
		// Note: this type is marked as 'beforefieldinit'.
		static TypeIdentifiers()
		{
			Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeIdentifiers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr);
			TypeIdentifiers.NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr, 100667101);
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00087F40 File Offset: 0x00086140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309176, RefRangeEnd = 309177, XrefRangeStart = 309172, XrefRangeEnd = 309176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeIdentifier FromDisplay(string displayName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00008012 File Offset: 0x00006212
		public TypeIdentifiers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeMethodInfoPtr_FromDisplay_Internal_Static_TypeIdentifier_String_0;

		// Token: 0x020005B0 RID: 1456
		public class Display : TypeNames.ATypeName
		{
			// Token: 0x0600500C RID: 20492 RVA: 0x0016714C File Offset: 0x0016534C
			// Note: this type is marked as 'beforefieldinit'.
			static Display()
			{
				Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeIdentifiers>.NativeClassPtr, "Display");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr);
				TypeIdentifiers.Display.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, "displayName");
				TypeIdentifiers.Display.NativeFieldInfoPtr_internal_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, "internal_name");
				TypeIdentifiers.Display.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667102);
				TypeIdentifiers.Display.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667103);
				TypeIdentifiers.Display.NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667104);
				TypeIdentifiers.Display.NativeMethodInfoPtr_GetInternalName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr, 100667105);
			}

			// Token: 0x0600500D RID: 20493 RVA: 0x001671F0 File Offset: 0x001653F0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 255404, RefRangeEnd = 255408, XrefRangeStart = 255404, XrefRangeEnd = 255408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Display(string displayName)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeIdentifiers.Display>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.Display.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001469 RID: 5225
			// (get) Token: 0x0600500E RID: 20494 RVA: 0x0016723C File Offset: 0x0016543C
			public unsafe override string DisplayName
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeIdentifiers.Display.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x1700146A RID: 5226
			// (get) Token: 0x0600500F RID: 20495 RVA: 0x00167280 File Offset: 0x00165480
			public unsafe virtual string InternalName
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309170, XrefRangeEnd = 309171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.Display.NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005010 RID: 20496 RVA: 0x001672B8 File Offset: 0x001654B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309171, XrefRangeEnd = 309172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetInternalName()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeIdentifiers.Display.NativeMethodInfoPtr_GetInternalName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06005011 RID: 20497 RVA: 0x0001E720 File Offset: 0x0001C920
			public Display(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001467 RID: 5223
			// (get) Token: 0x06005012 RID: 20498 RVA: 0x001672F0 File Offset: 0x001654F0
			// (set) Token: 0x06005013 RID: 20499 RVA: 0x0001E729 File Offset: 0x0001C929
			public unsafe string displayName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_displayName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001468 RID: 5224
			// (get) Token: 0x06005014 RID: 20500 RVA: 0x00167318 File Offset: 0x00165518
			// (set) Token: 0x06005015 RID: 20501 RVA: 0x0001E748 File Offset: 0x0001C948
			public unsafe string internal_name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_internal_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeIdentifiers.Display.NativeFieldInfoPtr_internal_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04004118 RID: 16664
			private static readonly IntPtr NativeFieldInfoPtr_displayName;

			// Token: 0x04004119 RID: 16665
			private static readonly IntPtr NativeFieldInfoPtr_internal_name;

			// Token: 0x0400411A RID: 16666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

			// Token: 0x0400411B RID: 16667
			private static readonly IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_get_String_0;

			// Token: 0x0400411C RID: 16668
			private static readonly IntPtr NativeMethodInfoPtr_get_InternalName_Public_Virtual_Final_New_get_String_0;

			// Token: 0x0400411D RID: 16669
			private static readonly IntPtr NativeMethodInfoPtr_GetInternalName_Private_String_0;
		}
	}
}
