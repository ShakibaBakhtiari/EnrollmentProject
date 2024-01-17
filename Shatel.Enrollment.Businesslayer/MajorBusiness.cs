using Shatel.Enrollment.DataAccess;
using Shatel.Enrollment.Utility;
using Shatel.Enrollment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shatel.Enrollment.Entities;

namespace Shatel.Enrollment.Businesslayer
{
    public class MajorBusinss
    {
        MajorRepository majorRepository = new MajorRepository();
        
        public void InsertMajor(MajorDTO majorDTO)
        {
            majorRepository.InsertMajor(majorDTO);
        }
        public List<Major> GetAllMajor()
        {
            majorRepository.ReadAll();
            return majorRepository.ReadAll();
        }
        public bool ChangeInfoMajor(MajorDTO majorDTO)
        {
            majorRepository.Update(new MajorMapper().MapDTOToModel(majorDTO));
            return true;
        }
        public bool DeleteInfoMajor(int Id)
        {
            majorRepository.DeleteById(Id);
            return true;
        }
    }
}
