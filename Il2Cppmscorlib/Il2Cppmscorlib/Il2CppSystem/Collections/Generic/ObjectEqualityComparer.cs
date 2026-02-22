using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x02000497 RID: 1175
	public sealed class ObjectEqualityComparer : Object
	{
		// Token: 0x06004640 RID: 17984 RVA: 0x00141F90 File Offset: 0x00140190
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectEqualityComparer()
		{
			Il2CppClassPointerStore<ObjectEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ObjectEqualityComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectEqualityComparer>.NativeClassPtr);
			ObjectEqualityComparer.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectEqualityComparer>.NativeClassPtr, "Default");
			ObjectEqualityComparer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectEqualityComparer>.NativeClassPtr, 100673700);
			ObjectEqualityComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectEqualityComparer>.NativeClassPtr, 100673701);
			ObjectEqualityComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectEqualityComparer>.NativeClassPtr, 100673702);
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x00142010 File Offset: 0x00140210
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectEqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectEqualityComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectEqualityComparer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x0014204C File Offset: 0x0014024C
		[CallerCount(0)]
		public unsafe int System_Collections_IEqualityComparer_GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectEqualityComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x0014209C File Offset: 0x0014029C
		[CallerCount(0)]
		public unsafe bool System_Collections_IEqualityComparer_Equals(Object x, Object y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectEqualityComparer.NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x0001AB51 File Offset: 0x00018D51
		public ObjectEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x06004645 RID: 17989 RVA: 0x001420FC File Offset: 0x001402FC
		// (set) Token: 0x06004646 RID: 17990 RVA: 0x0001AB5A File Offset: 0x00018D5A
		public unsafe static ObjectEqualityComparer Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ObjectEqualityComparer.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectEqualityComparer.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003914 RID: 14612
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04003915 RID: 14613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04003916 RID: 14614
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_GetHashCode_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04003917 RID: 14615
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEqualityComparer_Equals_Private_Virtual_Final_New_Boolean_Object_Object_0;
	}
}
