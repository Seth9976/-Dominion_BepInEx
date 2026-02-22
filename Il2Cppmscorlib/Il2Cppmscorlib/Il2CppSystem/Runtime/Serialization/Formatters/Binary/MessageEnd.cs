using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000365 RID: 869
	public sealed class MessageEnd : Object
	{
		// Token: 0x06003758 RID: 14168 RVA: 0x0010B2A4 File Offset: 0x001094A4
		// Note: this type is marked as 'beforefieldinit'.
		static MessageEnd()
		{
			Il2CppClassPointerStore<MessageEnd>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "MessageEnd");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageEnd>.NativeClassPtr);
			MessageEnd.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageEnd>.NativeClassPtr, 100671750);
			MessageEnd.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageEnd>.NativeClassPtr, 100671751);
			MessageEnd.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageEnd>.NativeClassPtr, 100671752);
			MessageEnd.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageEnd>.NativeClassPtr, 100671753);
			MessageEnd.NativeMethodInfoPtr_Dump_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageEnd>.NativeClassPtr, 100671754);
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x0010B338 File Offset: 0x00109538
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageEnd()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageEnd>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageEnd.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x0010B374 File Offset: 0x00109574
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 345140, RefRangeEnd = 345141, XrefRangeStart = 345138, XrefRangeEnd = 345140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageEnd.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x0010B3B8 File Offset: 0x001095B8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageEnd.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x0010B3FC File Offset: 0x001095FC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageEnd.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x0010B430 File Offset: 0x00109630
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump(Stream sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageEnd.NativeMethodInfoPtr_Dump_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x000140BC File Offset: 0x000122BC
		public MessageEnd(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E6D RID: 11885
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002E6E RID: 11886
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002E6F RID: 11887
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002E70 RID: 11888
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;

		// Token: 0x04002E71 RID: 11889
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_Stream_0;
	}
}
