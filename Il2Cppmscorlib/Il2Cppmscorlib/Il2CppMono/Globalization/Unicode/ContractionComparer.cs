using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000017 RID: 23
	public class ContractionComparer : Object
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x000253EC File Offset: 0x000235EC
		// Note: this type is marked as 'beforefieldinit'.
		static ContractionComparer()
		{
			Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "ContractionComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr);
			ContractionComparer.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr, "Instance");
			ContractionComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Contraction_Contraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr, 100663415);
			ContractionComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr, 100663416);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00025458 File Offset: 0x00023658
		[CallerCount(0)]
		public unsafe virtual int Compare(Contraction c1, Contraction c2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractionComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Contraction_Contraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000254B8 File Offset: 0x000236B8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractionComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContractionComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContractionComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000251F File Offset: 0x0000071F
		public ContractionComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000254F4 File Offset: 0x000236F4
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002528 File Offset: 0x00000728
		public unsafe static ContractionComparer Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ContractionComparer.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractionComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ContractionComparer.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Contraction_Contraction_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
