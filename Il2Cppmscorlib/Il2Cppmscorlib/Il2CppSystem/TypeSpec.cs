using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000144 RID: 324
	public class TypeSpec : Object
	{
		// Token: 0x060016C2 RID: 5826 RVA: 0x000884A8 File Offset: 0x000866A8
		// Note: this type is marked as 'beforefieldinit'.
		static TypeSpec()
		{
			Il2CppClassPointerStore<TypeSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypeSpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr);
			TypeSpec.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "name");
			TypeSpec.NativeFieldInfoPtr_assembly_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "assembly_name");
			TypeSpec.NativeFieldInfoPtr_nested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "nested");
			TypeSpec.NativeFieldInfoPtr_generic_params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "generic_params");
			TypeSpec.NativeFieldInfoPtr_modifier_spec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "modifier_spec");
			TypeSpec.NativeFieldInfoPtr_is_byref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "is_byref");
			TypeSpec.NativeFieldInfoPtr_display_fullname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, "display_fullname");
			TypeSpec.NativeMethodInfoPtr_get_HasModifiers_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667116);
			TypeSpec.NativeMethodInfoPtr_GetDisplayFullName_Private_String_DisplayNameFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667117);
			TypeSpec.NativeMethodInfoPtr_GetModifierString_Private_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667118);
			TypeSpec.NativeMethodInfoPtr_get_DisplayFullName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667119);
			TypeSpec.NativeMethodInfoPtr_Parse_Internal_Static_TypeSpec_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667120);
			TypeSpec.NativeMethodInfoPtr_UnescapeInternalName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667121);
			TypeSpec.NativeMethodInfoPtr_Resolve_Internal_Type_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667122);
			TypeSpec.NativeMethodInfoPtr_AddName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667123);
			TypeSpec.NativeMethodInfoPtr_AddModifier_Private_Void_ModifierSpec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667124);
			TypeSpec.NativeMethodInfoPtr_SkipSpace_Private_Static_Void_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667125);
			TypeSpec.NativeMethodInfoPtr_BoundCheck_Private_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667126);
			TypeSpec.NativeMethodInfoPtr_ParsedTypeIdentifier_Private_Static_TypeIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667127);
			TypeSpec.NativeMethodInfoPtr_Parse_Private_Static_TypeSpec_String_byref_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667128);
			TypeSpec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr, 100667129);
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x0008867C File Offset: 0x0008687C
		public unsafe bool HasModifiers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 254453, RefRangeEnd = 254454, XrefRangeStart = 254453, XrefRangeEnd = 254454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_get_HasModifiers_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000886B8 File Offset: 0x000868B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 309258, RefRangeEnd = 309262, XrefRangeStart = 309206, XrefRangeEnd = 309258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayFullName(TypeSpec.DisplayNameFormat flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_GetDisplayFullName_Private_String_DisplayNameFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000886FC File Offset: 0x000868FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309281, RefRangeEnd = 309282, XrefRangeStart = 309262, XrefRangeEnd = 309281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringBuilder GetModifierString(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_GetModifierString_Private_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x0008874C File Offset: 0x0008694C
		public unsafe string DisplayFullName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309282, XrefRangeEnd = 309283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_get_DisplayFullName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00088784 File Offset: 0x00086984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309283, XrefRangeEnd = 309284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeSpec Parse(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_Parse_Internal_Static_TypeSpec_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeSpec>(intPtr3) : null;
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000887C8 File Offset: 0x000869C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309293, RefRangeEnd = 309295, XrefRangeStart = 309284, XrefRangeEnd = 309293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnescapeInternalName(string displayName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_UnescapeInternalName_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00088804 File Offset: 0x00086A04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309320, RefRangeEnd = 309322, XrefRangeStart = 309295, XrefRangeEnd = 309320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyResolver);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeResolver);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_Resolve_Internal_Type_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00088884 File Offset: 0x00086A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 309339, RefRangeEnd = 309341, XrefRangeStart = 309322, XrefRangeEnd = 309339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddName(string type_name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type_name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_AddName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x000888C8 File Offset: 0x00086AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309341, XrefRangeEnd = 309351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddModifier(ModifierSpec md)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(md);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_AddModifier_Private_Void_ModifierSpec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x0008890C File Offset: 0x00086B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309351, XrefRangeEnd = 309357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SkipSpace(string name, ref int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_SkipSpace_Private_Static_Void_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00088950 File Offset: 0x00086B50
		[CallerCount(0)]
		public unsafe static void BoundCheck(int idx, string s)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_BoundCheck_Private_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00088994 File Offset: 0x00086B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309176, RefRangeEnd = 309177, XrefRangeStart = 309176, XrefRangeEnd = 309177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeIdentifier ParsedTypeIdentifier(string displayName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_ParsedTypeIdentifier_Private_Static_TypeIdentifier_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeIdentifier>(intPtr3) : null;
			}
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x000889D8 File Offset: 0x00086BD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 309381, RefRangeEnd = 309384, XrefRangeStart = 309357, XrefRangeEnd = 309381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &p;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref is_recurse;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allow_aqn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr_Parse_Private_Static_TypeSpec_String_byref_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeSpec>(intPtr3) : null;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00088A48 File Offset: 0x00086C48
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeSpec()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeSpec>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeSpec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00008087 File Offset: 0x00006287
		public TypeSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x00088A84 File Offset: 0x00086C84
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00008090 File Offset: 0x00006290
		public unsafe TypeIdentifier name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeIdentifier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x00088AB4 File Offset: 0x00086CB4
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x000080AF File Offset: 0x000062AF
		public unsafe string assembly_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_assembly_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_assembly_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x00088ADC File Offset: 0x00086CDC
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x000080CE File Offset: 0x000062CE
		public unsafe List<TypeIdentifier> nested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_nested);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TypeIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_nested), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x00088B0C File Offset: 0x00086D0C
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x000080ED File Offset: 0x000062ED
		public unsafe List<TypeSpec> generic_params
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_generic_params);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TypeSpec>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_generic_params), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x00088B3C File Offset: 0x00086D3C
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x0000810C File Offset: 0x0000630C
		public unsafe List<ModifierSpec> modifier_spec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_modifier_spec);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ModifierSpec>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_modifier_spec), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x00088B6C File Offset: 0x00086D6C
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x0000812B File Offset: 0x0000632B
		public unsafe bool is_byref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_is_byref);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_is_byref)) = value;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00088B94 File Offset: 0x00086D94
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x00008146 File Offset: 0x00006346
		public unsafe string display_fullname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_display_fullname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeSpec.NativeFieldInfoPtr_display_fullname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeFieldInfoPtr_assembly_name;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeFieldInfoPtr_nested;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeFieldInfoPtr_generic_params;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeFieldInfoPtr_modifier_spec;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeFieldInfoPtr_is_byref;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeFieldInfoPtr_display_fullname;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeMethodInfoPtr_get_HasModifiers_Internal_get_Boolean_0;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayFullName_Private_String_DisplayNameFormat_0;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeMethodInfoPtr_GetModifierString_Private_StringBuilder_StringBuilder_0;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayFullName_Internal_get_String_0;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_TypeSpec_String_0;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeInternalName_Internal_Static_String_String_0;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Internal_Type_Func_2_AssemblyName_Assembly_Func_4_Assembly_String_Boolean_Type_Boolean_Boolean_0;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr_AddName_Private_Void_String_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_AddModifier_Private_Void_ModifierSpec_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr_SkipSpace_Private_Static_Void_String_byref_Int32_0;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr_BoundCheck_Private_Static_Void_Int32_String_0;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeMethodInfoPtr_ParsedTypeIdentifier_Private_Static_TypeIdentifier_String_0;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Static_TypeSpec_String_byref_Int32_Boolean_Boolean_0;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005B1 RID: 1457
		[Flags]
		public enum DisplayNameFormat
		{
			// Token: 0x0400411F RID: 16671
			Default = 0,
			// Token: 0x04004120 RID: 16672
			WANT_ASSEMBLY = 1,
			// Token: 0x04004121 RID: 16673
			NO_MODIFIERS = 2
		}
	}
}
