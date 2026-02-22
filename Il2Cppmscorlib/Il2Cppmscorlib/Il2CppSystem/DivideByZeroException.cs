using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200009A RID: 154
	[Serializable]
	public class DivideByZeroException : ArithmeticException
	{
		// Token: 0x06000AD5 RID: 2773 RVA: 0x00053120 File Offset: 0x00051320
		// Note: this type is marked as 'beforefieldinit'.
		static DivideByZeroException()
		{
			Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DivideByZeroException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr);
			DivideByZeroException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr, 100665112);
			DivideByZeroException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr, 100665113);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00053178 File Offset: 0x00051378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281885, XrefRangeEnd = 281890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DivideByZeroException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivideByZeroException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000531B4 File Offset: 0x000513B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DivideByZeroException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DivideByZeroException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DivideByZeroException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00004D4E File Offset: 0x00002F4E
		public DivideByZeroException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
