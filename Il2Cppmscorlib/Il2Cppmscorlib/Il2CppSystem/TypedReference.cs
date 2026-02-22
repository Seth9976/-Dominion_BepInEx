using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x020000F7 RID: 247
	[StructLayout(2)]
	public struct TypedReference
	{
		// Token: 0x0600121C RID: 4636 RVA: 0x000765E8 File Offset: 0x000747E8
		// Note: this type is marked as 'beforefieldinit'.
		static TypedReference()
		{
			Il2CppClassPointerStore<TypedReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TypedReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedReference>.NativeClassPtr);
			TypedReference.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, "type");
			TypedReference.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, "Value");
			TypedReference.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, "Type");
			TypedReference.NativeMethodInfoPtr_MakeTypedReference_Public_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666458);
			TypedReference.NativeMethodInfoPtr_MakeTypedReferenceInternal_Private_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666459);
			TypedReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666460);
			TypedReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666461);
			TypedReference.NativeMethodInfoPtr_get_IsNull_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666462);
			TypedReference.NativeMethodInfoPtr_SetTypedReference_Public_Static_Void_TypedReference_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, 100666463);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x000766CC File Offset: 0x000748CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302567, RefRangeEnd = 302568, XrefRangeStart = 302546, XrefRangeEnd = 302567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedReference MakeTypedReference(Object target, Il2CppReferenceArray<FieldInfo> flds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_MakeTypedReference_Public_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00076720 File Offset: 0x00074920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302568, XrefRangeEnd = 302569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypedReference MakeTypedReferenceInternal(Object target, Il2CppReferenceArray<FieldInfo> fields)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fields);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_MakeTypedReferenceInternal_Private_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x00076774 File Offset: 0x00074974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302569, XrefRangeEnd = 302575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000767A4 File Offset: 0x000749A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302575, XrefRangeEnd = 302582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x000767E8 File Offset: 0x000749E8
		public unsafe bool IsNull
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 302583, RefRangeEnd = 302584, XrefRangeStart = 302582, XrefRangeEnd = 302583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_get_IsNull_Internal_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00076818 File Offset: 0x00074A18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302590, RefRangeEnd = 302591, XrefRangeStart = 302584, XrefRangeEnd = 302590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetTypedReference(TypedReference target, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedReference.NativeMethodInfoPtr_SetTypedReference_Public_Static_Void_TypedReference_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00006523 File Offset: 0x00004723
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TypedReference>.NativeClassPtr, ref this));
		}

		// Token: 0x04000FAF RID: 4015
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000FB0 RID: 4016
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04000FB1 RID: 4017
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04000FB2 RID: 4018
		private static readonly IntPtr NativeMethodInfoPtr_MakeTypedReference_Public_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0;

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_MakeTypedReferenceInternal_Private_Static_TypedReference_Object_Il2CppReferenceArray_1_FieldInfo_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNull_Internal_get_Boolean_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_SetTypedReference_Public_Static_Void_TypedReference_Object_0;

		// Token: 0x04000FB8 RID: 4024
		[FieldOffset(0)]
		public RuntimeTypeHandle type;

		// Token: 0x04000FB9 RID: 4025
		[FieldOffset(8)]
		public IntPtr Value;

		// Token: 0x04000FBA RID: 4026
		[FieldOffset(16)]
		public IntPtr Type;
	}
}
