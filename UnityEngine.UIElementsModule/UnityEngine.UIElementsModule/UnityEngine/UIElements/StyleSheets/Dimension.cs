using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020000E2 RID: 226
	[Serializable]
	[StructLayout(2)]
	public struct Dimension
	{
		// Token: 0x06000C93 RID: 3219 RVA: 0x00032930 File Offset: 0x00030B30
		// Note: this type is marked as 'beforefieldinit'.
		static Dimension()
		{
			Il2CppClassPointerStore<Dimension>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "Dimension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dimension>.NativeClassPtr);
			Dimension.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dimension>.NativeClassPtr, "unit");
			Dimension.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dimension>.NativeClassPtr, "value");
			Dimension.NativeMethodInfoPtr__ctor_Public_Void_Single_Unit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100664272);
			Dimension.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Dimension_Dimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100664273);
			Dimension.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Dimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100664274);
			Dimension.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100664275);
			Dimension.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100664276);
			Dimension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dimension>.NativeClassPtr, 100664277);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00032A00 File Offset: 0x00030C00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 97249, RefRangeEnd = 97251, XrefRangeStart = 97249, XrefRangeEnd = 97249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dimension(float value, Dimension.Unit unit)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr__ctor_Public_Void_Single_Unit_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00032A40 File Offset: 0x00030C40
		[CallerCount(0)]
		public unsafe static bool operator ==(Dimension lhs, Dimension rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Dimension_Dimension_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00032A8C File Offset: 0x00030C8C
		[CallerCount(0)]
		public unsafe bool Equals(Dimension other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Dimension_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00032ACC File Offset: 0x00030CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97251, XrefRangeEnd = 97254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00032B10 File Offset: 0x00030D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97254, XrefRangeEnd = 97256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00032B40 File Offset: 0x00030D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97256, XrefRangeEnd = 97270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dimension.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00007FA1 File Offset: 0x000061A1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dimension>.NativeClassPtr, ref this));
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00032B6C File Offset: 0x00030D6C
		public Length ToLength()
		{
			LengthUnit lengthUnit = ((this.unit == Dimension.Unit.Percent) ? LengthUnit.Percent : LengthUnit.Pixel);
			return new Length(this.value, lengthUnit);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00032B98 File Offset: 0x00030D98
		public static bool operator !=(Dimension lhs, Dimension rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_unit;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Unit_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Dimension_Dimension_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Dimension_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000723 RID: 1827
		[FieldOffset(0)]
		public Dimension.Unit unit;

		// Token: 0x04000724 RID: 1828
		[FieldOffset(4)]
		public float value;

		// Token: 0x0200022D RID: 557
		public enum Unit
		{
			// Token: 0x04000905 RID: 2309
			Unitless,
			// Token: 0x04000906 RID: 2310
			Pixel,
			// Token: 0x04000907 RID: 2311
			Percent
		}
	}
}
