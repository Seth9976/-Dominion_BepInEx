using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200007A RID: 122
	[Serializable]
	public class ArrayTypeMismatchException : SystemException
	{
		// Token: 0x0600074F RID: 1871 RVA: 0x00042E40 File Offset: 0x00041040
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayTypeMismatchException()
		{
			Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArrayTypeMismatchException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr);
			ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr, 100664439);
			ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr, 100664440);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00042E98 File Offset: 0x00041098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276315, XrefRangeEnd = 276320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayTypeMismatchException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00042ED4 File Offset: 0x000410D4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayTypeMismatchException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArrayTypeMismatchException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayTypeMismatchException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00004578 File Offset: 0x00002778
		public ArrayTypeMismatchException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
