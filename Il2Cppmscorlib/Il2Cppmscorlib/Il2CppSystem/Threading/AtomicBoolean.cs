using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000255 RID: 597
	public class AtomicBoolean : Object
	{
		// Token: 0x06002973 RID: 10611 RVA: 0x000D7640 File Offset: 0x000D5840
		// Note: this type is marked as 'beforefieldinit'.
		static AtomicBoolean()
		{
			Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AtomicBoolean");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr);
			AtomicBoolean.NativeFieldInfoPtr_flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, "flag");
			AtomicBoolean.NativeMethodInfoPtr_TryRelaxedSet_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100669915);
			AtomicBoolean.NativeMethodInfoPtr_Exchange_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100669916);
			AtomicBoolean.NativeMethodInfoPtr_Equals_Public_Boolean_AtomicBoolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100669917);
			AtomicBoolean.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100669918);
			AtomicBoolean.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100669919);
			AtomicBoolean.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr, 100669920);
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x000D76FC File Offset: 0x000D58FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330047, RefRangeEnd = 330049, XrefRangeStart = 330047, XrefRangeEnd = 330047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryRelaxedSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtomicBoolean.NativeMethodInfoPtr_TryRelaxedSet_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x000D7738 File Offset: 0x000D5938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330049, XrefRangeEnd = 330050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Exchange(bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtomicBoolean.NativeMethodInfoPtr_Exchange_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x000D7784 File Offset: 0x000D5984
		[CallerCount(0)]
		public unsafe bool Equals(AtomicBoolean rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rhs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtomicBoolean.NativeMethodInfoPtr_Equals_Public_Boolean_AtomicBoolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x000D77D4 File Offset: 0x000D59D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330050, XrefRangeEnd = 330052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rhs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtomicBoolean.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x000D782C File Offset: 0x000D5A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330052, XrefRangeEnd = 330053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AtomicBoolean.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000D7874 File Offset: 0x000D5A74
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AtomicBoolean()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AtomicBoolean>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AtomicBoolean.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0000E6E5 File Offset: 0x0000C8E5
		public AtomicBoolean(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x0600297B RID: 10619 RVA: 0x000D78B0 File Offset: 0x000D5AB0
		// (set) Token: 0x0600297C RID: 10620 RVA: 0x0000E6EE File Offset: 0x0000C8EE
		public unsafe int flag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtomicBoolean.NativeFieldInfoPtr_flag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AtomicBoolean.NativeFieldInfoPtr_flag)) = value;
			}
		}

		// Token: 0x04002486 RID: 9350
		private static readonly IntPtr NativeFieldInfoPtr_flag;

		// Token: 0x04002487 RID: 9351
		private static readonly IntPtr NativeMethodInfoPtr_TryRelaxedSet_Public_Boolean_0;

		// Token: 0x04002488 RID: 9352
		private static readonly IntPtr NativeMethodInfoPtr_Exchange_Public_Boolean_Boolean_0;

		// Token: 0x04002489 RID: 9353
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_AtomicBoolean_0;

		// Token: 0x0400248A RID: 9354
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400248B RID: 9355
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400248C RID: 9356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
