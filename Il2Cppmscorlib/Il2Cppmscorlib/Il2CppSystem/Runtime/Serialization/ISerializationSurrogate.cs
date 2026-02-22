using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200032F RID: 815
	public class ISerializationSurrogate : Il2CppObjectBase
	{
		// Token: 0x06003489 RID: 13449 RVA: 0x00101168 File Offset: 0x000FF368
		// Note: this type is marked as 'beforefieldinit'.
		static ISerializationSurrogate()
		{
			Il2CppClassPointerStore<ISerializationSurrogate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ISerializationSurrogate");
			ISerializationSurrogate.NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationSurrogate>.NativeClassPtr, 100671445);
			ISerializationSurrogate.NativeMethodInfoPtr_SetObjectData_Public_Abstract_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISerializationSurrogate>.NativeClassPtr, 100671446);
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x001011B8 File Offset: 0x000FF3B8
		[CallerCount(0)]
		public unsafe virtual void GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationSurrogate.NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x00101230 File Offset: 0x000FF430
		[CallerCount(0)]
		public unsafe virtual Object SetObjectData(Object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISerializationSurrogate.NativeMethodInfoPtr_SetObjectData_Public_Abstract_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x00012BB5 File Offset: 0x00010DB5
		public ISerializationSurrogate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C8E RID: 11406
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Abstract_Virtual_New_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x04002C8F RID: 11407
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectData_Public_Abstract_Virtual_New_Object_Object_SerializationInfo_StreamingContext_ISurrogateSelector_0;
	}
}
