using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000382 RID: 898
	public sealed class SerStack : Object
	{
		// Token: 0x06003A8A RID: 14986 RVA: 0x00115D78 File Offset: 0x00113F78
		// Note: this type is marked as 'beforefieldinit'.
		static SerStack()
		{
			Il2CppClassPointerStore<SerStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerStack>.NativeClassPtr);
			SerStack.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerStack>.NativeClassPtr, "objects");
			SerStack.NativeFieldInfoPtr_stackId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerStack>.NativeClassPtr, "stackId");
			SerStack.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerStack>.NativeClassPtr, "top");
			SerStack.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672006);
			SerStack.NativeMethodInfoPtr_Push_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672007);
			SerStack.NativeMethodInfoPtr_Pop_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672008);
			SerStack.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672009);
			SerStack.NativeMethodInfoPtr_Peek_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672010);
			SerStack.NativeMethodInfoPtr_PeekPeek_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672011);
			SerStack.NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672012);
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x00115E70 File Offset: 0x00114070
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 348479, RefRangeEnd = 348484, XrefRangeStart = 348475, XrefRangeEnd = 348479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerStack(string stackId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerStack>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stackId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x00115EBC File Offset: 0x001140BC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 348489, RefRangeEnd = 348511, XrefRangeStart = 348484, XrefRangeEnd = 348489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_Push_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x00115F00 File Offset: 0x00114100
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 348511, RefRangeEnd = 348514, XrefRangeStart = 348511, XrefRangeEnd = 348511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_Pop_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x00115F40 File Offset: 0x00114140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 348514, XrefRangeEnd = 348518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x00115F74 File Offset: 0x00114174
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 348518, RefRangeEnd = 348528, XrefRangeStart = 348518, XrefRangeEnd = 348518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_Peek_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x00115FB4 File Offset: 0x001141B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 348528, RefRangeEnd = 348534, XrefRangeStart = 348528, XrefRangeEnd = 348528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object PeekPeek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_PeekPeek_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x00115FF4 File Offset: 0x001141F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 348534, RefRangeEnd = 348538, XrefRangeStart = 348534, XrefRangeEnd = 348534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x00015E51 File Offset: 0x00014051
		public SerStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x06003A93 RID: 14995 RVA: 0x00116030 File Offset: 0x00114230
		// (set) Token: 0x06003A94 RID: 14996 RVA: 0x00015E5A File Offset: 0x0001405A
		public unsafe Il2CppReferenceArray<Object> objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06003A95 RID: 14997 RVA: 0x00116060 File Offset: 0x00114260
		// (set) Token: 0x06003A96 RID: 14998 RVA: 0x00015E79 File Offset: 0x00014079
		public unsafe string stackId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_stackId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_stackId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06003A97 RID: 14999 RVA: 0x00116088 File Offset: 0x00114288
		// (set) Token: 0x06003A98 RID: 15000 RVA: 0x00015E98 File Offset: 0x00014098
		public unsafe int top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_top);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_top)) = value;
			}
		}

		// Token: 0x040030EE RID: 12526
		private static readonly IntPtr NativeFieldInfoPtr_objects;

		// Token: 0x040030EF RID: 12527
		private static readonly IntPtr NativeFieldInfoPtr_stackId;

		// Token: 0x040030F0 RID: 12528
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x040030F1 RID: 12529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x040030F2 RID: 12530
		private static readonly IntPtr NativeMethodInfoPtr_Push_Internal_Void_Object_0;

		// Token: 0x040030F3 RID: 12531
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Internal_Object_0;

		// Token: 0x040030F4 RID: 12532
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_0;

		// Token: 0x040030F5 RID: 12533
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Internal_Object_0;

		// Token: 0x040030F6 RID: 12534
		private static readonly IntPtr NativeMethodInfoPtr_PeekPeek_Internal_Object_0;

		// Token: 0x040030F7 RID: 12535
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0;
	}
}
