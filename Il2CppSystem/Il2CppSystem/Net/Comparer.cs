using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000ED RID: 237
	public class Comparer : Object
	{
		// Token: 0x06000DDE RID: 3550 RVA: 0x00044548 File Offset: 0x00042748
		// Note: this type is marked as 'beforefieldinit'.
		static Comparer()
		{
			Il2CppClassPointerStore<Comparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Comparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Comparer>.NativeClassPtr);
			Comparer.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100665241);
			Comparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100665242);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x000445A0 File Offset: 0x000427A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48229, XrefRangeEnd = 48234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IComparer_Compare(Object ol, Object or)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ol);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(or);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00044600 File Offset: 0x00042800
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Comparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Comparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0000772E File Offset: 0x0000592E
		public Comparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
