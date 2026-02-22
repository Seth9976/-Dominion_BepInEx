using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace TMPro
{
	// Token: 0x02000004 RID: 4
	public class FastAction<A, B> : Object
	{
		// Token: 0x06000015 RID: 21 RVA: 0x0000A200 File Offset: 0x00008400
		// Note: this type is marked as 'beforefieldinit'.
		static FastAction()
		{
			Il2CppClassPointerStore<FastAction<A, B>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "FastAction`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<A>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<B>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastAction<A, B>>.NativeClassPtr);
			FastAction<A, B>.NativeFieldInfoPtr_delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastAction<A, B>>.NativeClassPtr, "delegates");
			FastAction<A, B>.NativeFieldInfoPtr_lookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastAction<A, B>>.NativeClassPtr, "lookup");
			FastAction<A, B>.NativeMethodInfoPtr_Add_Public_Void_Action_2_A_B_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A, B>>.NativeClassPtr, 100663305);
			FastAction<A, B>.NativeMethodInfoPtr_Remove_Public_Void_Action_2_A_B_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A, B>>.NativeClassPtr, 100663306);
			FastAction<A, B>.NativeMethodInfoPtr_Call_Public_Void_A_B_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A, B>>.NativeClassPtr, 100663307);
			FastAction<A, B>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastAction<A, B>>.NativeClassPtr, 100663308);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000A2F8 File Offset: 0x000084F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 131878, RefRangeEnd = 131885, XrefRangeStart = 131878, XrefRangeEnd = 131885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Action<A, B> rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rhs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastAction<A, B>.NativeMethodInfoPtr_Add_Public_Void_Action_2_A_B_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000A33C File Offset: 0x0000853C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131892, XrefRangeStart = 131885, XrefRangeEnd = 131892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(Action<A, B> rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rhs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastAction<A, B>.NativeMethodInfoPtr_Remove_Public_Void_Action_2_A_B_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000A380 File Offset: 0x00008580
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 131908, RefRangeEnd = 131913, XrefRangeStart = 131908, XrefRangeEnd = 131908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Call(A a, B b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(A).IsValueType)
				{
					A a2 = a;
					intPtr = ((a2 is string) ? IL2CPP.ManagedStringToIl2Cpp(a2 as string) : IL2CPP.Il2CppObjectBaseToPtr(a2 as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref a;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(B).IsValueType)
			{
				B b2 = b;
				intPtr2 = ((b2 is string) ? IL2CPP.ManagedStringToIl2Cpp(b2 as string) : IL2CPP.Il2CppObjectBaseToPtr(b2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref b;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(FastAction<A, B>.NativeMethodInfoPtr_Call_Public_Void_A_B_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000A440 File Offset: 0x00008640
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 131898, RefRangeEnd = 131908, XrefRangeStart = 131898, XrefRangeEnd = 131908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FastAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastAction<A, B>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastAction<A, B>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020DE File Offset: 0x000002DE
		public FastAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001B RID: 27 RVA: 0x0000A47C File Offset: 0x0000867C
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020E7 File Offset: 0x000002E7
		public unsafe LinkedList<Action<A, B>> delegates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A, B>.NativeFieldInfoPtr_delegates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedList<Action<A, B>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A, B>.NativeFieldInfoPtr_delegates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0000A4AC File Offset: 0x000086AC
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002106 File Offset: 0x00000306
		public unsafe Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A, B>.NativeFieldInfoPtr_lookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastAction<A, B>.NativeFieldInfoPtr_lookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_delegates;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_lookup;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Action_2_A_B_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Action_2_A_B_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_Void_A_B_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
