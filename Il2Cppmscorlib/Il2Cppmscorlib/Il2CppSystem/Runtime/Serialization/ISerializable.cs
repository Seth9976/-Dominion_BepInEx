using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032E RID: 814
	public class ISerializable : Il2CppObjectBase
	{
		// Token: 0x06003486 RID: 13446 RVA: 0x00012B7D File Offset: 0x00010D7D
		// Note: this type is marked as 'beforefieldinit'.
		static ISerializable()
		{
			Il2CppClassPointerStore<ISerializable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ISerializable");
			ISerializable.NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializable>.NativeClassPtr, 100671444);
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x00101104 File Offset: 0x000FF304
		[CallerCount(0)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializable.NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x00012BAC File Offset: 0x00010DAC
		public ISerializable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C8D RID: 11405
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_SerializationInfo_StreamingContext_0;
	}
}
