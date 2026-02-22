using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000142 RID: 322
	public class ArraySpec : Object
	{
		// Token: 0x060016B0 RID: 5808 RVA: 0x0008808C File Offset: 0x0008628C
		// Note: this type is marked as 'beforefieldinit'.
		static ArraySpec()
		{
			Il2CppClassPointerStore<ArraySpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArraySpec");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr);
			ArraySpec.NativeFieldInfoPtr_dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, "dimensions");
			ArraySpec.NativeFieldInfoPtr_bound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, "bound");
			ArraySpec.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, 100667108);
			ArraySpec.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, 100667109);
			ArraySpec.NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, 100667110);
			ArraySpec.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr, 100667111);
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00088134 File Offset: 0x00086334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309177, XrefRangeEnd = 309178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArraySpec(int dimensions, bool bound)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySpec>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dimensions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySpec.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0008818C File Offset: 0x0008638C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309178, XrefRangeEnd = 309179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type Resolve(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySpec.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x000881DC File Offset: 0x000863DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309179, XrefRangeEnd = 309186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual StringBuilder Append(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArraySpec.NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0008822C File Offset: 0x0008642C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309186, XrefRangeEnd = 309198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArraySpec.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00008024 File Offset: 0x00006224
		public ArraySpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x00088270 File Offset: 0x00086470
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x0000802D File Offset: 0x0000622D
		public unsafe int dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySpec.NativeFieldInfoPtr_dimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySpec.NativeFieldInfoPtr_dimensions)) = value;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x00088298 File Offset: 0x00086498
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x00008048 File Offset: 0x00006248
		public unsafe bool bound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySpec.NativeFieldInfoPtr_bound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArraySpec.NativeFieldInfoPtr_bound)) = value;
			}
		}

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeFieldInfoPtr_dimensions;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeFieldInfoPtr_bound;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Boolean_0;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Type_Type_0;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Virtual_Final_New_StringBuilder_StringBuilder_0;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
