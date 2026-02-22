using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000496 RID: 1174
	[Serializable]
	public sealed class NonRandomizedStringEqualityComparer : EqualityComparer<string>
	{
		// Token: 0x0600463B RID: 17979 RVA: 0x00141E38 File Offset: 0x00140038
		// Note: this type is marked as 'beforefieldinit'.
		static NonRandomizedStringEqualityComparer()
		{
			Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "NonRandomizedStringEqualityComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr);
			NonRandomizedStringEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr, 100673697);
			NonRandomizedStringEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr, 100673698);
			NonRandomizedStringEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr, 100673699);
		}

		// Token: 0x0600463C RID: 17980 RVA: 0x00141EA4 File Offset: 0x001400A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(string x, string y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonRandomizedStringEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x00141F04 File Offset: 0x00140104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363753, XrefRangeEnd = 363754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonRandomizedStringEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x00141F54 File Offset: 0x00140154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363754, XrefRangeEnd = 363757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NonRandomizedStringEqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NonRandomizedStringEqualityComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NonRandomizedStringEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600463F RID: 17983 RVA: 0x0001AB48 File Offset: 0x00018D48
		public NonRandomizedStringEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003911 RID: 14609
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_String_String_0;

		// Token: 0x04003912 RID: 14610
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_String_0;

		// Token: 0x04003913 RID: 14611
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
